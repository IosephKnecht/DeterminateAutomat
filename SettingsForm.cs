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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public event Action<object, object> OK_event;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            string sym = text.Text;
            try
            {
                text.Text = sym[sym.Length - 1].ToString();
                text.SelectionStart = text.Text.Length;
            }
            catch { }
        }

        public List<Node> Convert_nodes()
        {
            List<Node> conv_nodes = new List<Node>();

            for (int i = 0; i < nodes_gridview.Rows.Count; i++)
            {
                if (nodes_gridview.Rows[i].DefaultCellStyle.Font.Bold)
                    conv_nodes.Add(new Node(nodes_gridview.Rows[i].Cells[0].Value.ToString(), true));
                else
                    conv_nodes.Add(new Node(nodes_gridview.Rows[i].Cells[0].Value.ToString(), false));
            }

            return conv_nodes;
        }

        public List<string> Convert_transitions()
        {
            List<string> conv_transitions = new List<string>();

            for (int i = 0; i < transitions_gridview.Rows.Count; i++)
            {
                conv_transitions.Add(transitions_gridview.Rows[i].Cells[0].Value.ToString());
            }

            return conv_transitions;
        }

        private void transition_Radio_CheckedChanged(object sender, EventArgs e)
        {
            transitions_gridview.Visible = true;
            nodes_gridview.Visible = false;
            end_checkbox.Visible = false;
            end_checkbox.Checked = false;
            textBox1.Clear();
        }

        private void nodes_Radio_CheckedChanged(object sender, EventArgs e)
        {
            nodes_gridview.Visible = true;
            transitions_gridview.Visible = false;
            end_checkbox.Visible = true;
            textBox1.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nodes_Radio.Checked)
            {
                int row_num = nodes_gridview.Rows.Add(textBox1.Text);
                if (end_checkbox.Checked) nodes_gridview.Rows[row_num].DefaultCellStyle.Font =
                         new Font(nodes_gridview.DefaultCellStyle.Font, FontStyle.Bold);
            }
            else
            {
                transitions_gridview.Rows.Add(textBox1.Text);
            }
            //textBox1.Clear();
            end_checkbox.Checked = false;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (nodes_Radio.Checked&&nodes_gridview.Rows.Count>0) nodes_gridview.Rows.RemoveAt(nodes_gridview.Rows.GetLastRow(DataGridViewElementStates.None));
            else
                if(transitions_gridview.Rows.Count>0)
                transitions_gridview.Rows.RemoveAt(transitions_gridview.Rows.GetLastRow(DataGridViewElementStates.None));
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (nodes_Radio.Checked) nodes_gridview.Rows.Clear();
            else
                transitions_gridview.Rows.Clear();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            OK_event(Convert_nodes(), Convert_transitions());
            this.Close();
        }
    }
}
