using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.Data;

namespace WindowsFormsApp16
{
    public partial class out_auto : Form
    {
        private LinkCollection links;

        public out_auto(LinkCollection links)
        {
            InitializeComponent();
            this.links = links;
            Enter_table();
        }

        private void Enter_table()
        {
            for(int i=0;i<links.Count;i++)
            {
                Link link = links[i];
                int row_num = table.Rows.Add();
                table.Rows[row_num].Cells[0].Value = link.Start_node.Name;
                if (link.Start_node.Sost) table.Rows[row_num].Cells[0].Style.Font =
                         new Font(table.DefaultCellStyle.Font, FontStyle.Bold);
                table.Rows[row_num].Cells[1].Value = link.Trans;
                table.Rows[row_num].Cells[2].Value = link.Final_node.Name;
                if (link.Final_node.Sost) table.Rows[row_num].Cells[2].Style.Font =
                         new Font(table.DefaultCellStyle.Font, FontStyle.Bold);

            }
        }

        private void out_auto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (links.Count != 0)
            {
                VisualView visual = new VisualView(links);
                visual.ShowDialog();
            }
            else
            {
                MessageBox.Show("Массив линков пуст...");
            }
        }
    }
}
