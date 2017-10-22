using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;
using Label = Microsoft.Msagl.Drawing.Label;
using MouseButtons = System.Windows.Forms.MouseButtons;
using Point = Microsoft.Msagl.Core.Geometry.Point;
using WindowsFormsApp16.Data;
using System.Threading;

namespace WindowsFormsApp16
{
    public partial class VisualView : Form
    {
        public VisualView(LinkCollection links)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            EventArgs e=new EventArgs();
            this.OnResize(e);
            gViewer = new GViewer();
            Size g_size = this.MaximumSize;
            gViewer.Size = new Size(this.Height, this.Size.Height);
            //gViewer.Height = this.Height;
            gViewer.ToolBarIsVisible = false;
            gViewer.LayoutEditor.DecorateObjectForDragging = SetDragDecorator;
            gViewer.LayoutEditor.RemoveObjDraggingDecorations = RemoveDragDecorator;
            gViewer.MouseDown += WaMouseDown;
            gViewer.MouseUp += WaMouseUp;
            gViewer.MouseMove += GViewerOnMouseMove;
            this.links = links;
            Controls.Add(gViewer);
            //this.Load += Form1_Load;
            CreateGraph();
        }

        GViewer gViewer;
        System.Drawing.Point myMouseDownPoint;
        System.Drawing.Point myMouseUpPoint;
        readonly Dictionary<object, Color> draggedObjectOriginalColors = new Dictionary<object, Color>();
        Label labelToChange;
        IViewerObject viewerEntityCorrespondingToLabelToChange;
        LinkCollection links;

        void CreateGraph()
        {
            DisplayGeometryGraph.SetShowFunctions();
            Graph graph = new Graph();

            for (int i = 0; i < links.Count; i++)
            {
                graph.AddEdge(links[i].Start_node.Name, links[i].Final_node.Name).LabelText=links[i].Trans;
            }


            var subgraph = new Subgraph("Автомат");
            graph.RootSubgraph.AddSubgraph(subgraph);
            for (int i = 0; i < links.Count; i++)
            {
                subgraph.AddNode(graph.FindNode(links[i].Start_node.Name));
            }


            graph.Attr.LayerDirection = LayerDirection.LR;
            gViewer.Graph = graph;
        }

        void SetDragDecorator(IViewerObject obj)
        {
            var dNode = obj as DNode;
            if (dNode != null)
            {
                draggedObjectOriginalColors[dNode] = dNode.DrawingNode.Attr.Color;
                dNode.DrawingNode.Attr.Color = Color.Magenta;
                gViewer.Invalidate(obj);
            }
        }

        void RemoveDragDecorator(IViewerObject obj)
        {
            var dNode = obj as DNode;
            if (dNode != null)
            {
                dNode.DrawingNode.Attr.Color = draggedObjectOriginalColors[dNode];
                draggedObjectOriginalColors.Remove(obj);
                gViewer.Invalidate(obj);
            }
        }

        void WaMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                myMouseUpPoint = e.Location;
        }

        void WaMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                myMouseDownPoint = e.Location;
        }

        void GViewerOnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            if (labelToChange == null) return;
            labelToChange.Text = MousePosition.ToString();
            if (viewerEntityCorrespondingToLabelToChange == null)
            {
                foreach (var e in gViewer.Entities)
                {
                    if (e.DrawingObject == labelToChange)
                    {
                        viewerEntityCorrespondingToLabelToChange = e;
                        break;
                    }
                }
            }
            if (viewerEntityCorrespondingToLabelToChange == null) return;
            var rect = labelToChange.BoundingBox;
            var font = new Font(labelToChange.FontName, (int)labelToChange.FontSize);
            double width;
            double height;
            StringMeasure.MeasureWithFont(labelToChange.Text, font, out width, out height);

            if (width <= 0)
                //this is a temporary fix for win7 where Measure fonts return negative lenght for the string " "
                StringMeasure.MeasureWithFont("a", font, out width, out height);

            labelToChange.Width = width;
            labelToChange.Height = height;
            rect.Add(labelToChange.BoundingBox);
            gViewer.Invalidate(gViewer.MapSourceRectangleToScreenRectangle(rect));
        }
    }
}

