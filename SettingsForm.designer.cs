namespace WindowsFormsApp16
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nodes_gridview = new System.Windows.Forms.DataGridView();
            this.Node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.end_checkbox = new System.Windows.Forms.CheckBox();
            this.nodes_Radio = new System.Windows.Forms.RadioButton();
            this.transition_Radio = new System.Windows.Forms.RadioButton();
            this.transitions_gridview = new System.Windows.Forms.DataGridView();
            this.transition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitions_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // nodes_gridview
            // 
            this.nodes_gridview.AllowUserToAddRows = false;
            this.nodes_gridview.AllowUserToDeleteRows = false;
            this.nodes_gridview.AllowUserToResizeColumns = false;
            this.nodes_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nodes_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.nodes_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodes_gridview.BackgroundColor = System.Drawing.Color.OldLace;
            this.nodes_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodes_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.nodes_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodes_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Node});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nodes_gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.nodes_gridview.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.nodes_gridview.Location = new System.Drawing.Point(12, 12);
            this.nodes_gridview.Name = "nodes_gridview";
            this.nodes_gridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodes_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.nodes_gridview.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.nodes_gridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.nodes_gridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodes_gridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nodes_gridview.Size = new System.Drawing.Size(176, 229);
            this.nodes_gridview.TabIndex = 2;
            // 
            // Node
            // 
            this.Node.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Node.HeaderText = "Nodes";
            this.Node.Name = "Node";
            this.Node.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(194, 105);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(275, 105);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(194, 164);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(194, 135);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(156, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // end_checkbox
            // 
            this.end_checkbox.AutoSize = true;
            this.end_checkbox.Location = new System.Drawing.Point(275, 81);
            this.end_checkbox.Name = "end_checkbox";
            this.end_checkbox.Size = new System.Drawing.Size(84, 17);
            this.end_checkbox.TabIndex = 8;
            this.end_checkbox.Text = "End node..?";
            this.end_checkbox.UseVisualStyleBackColor = true;
            // 
            // nodes_Radio
            // 
            this.nodes_Radio.AutoSize = true;
            this.nodes_Radio.Checked = true;
            this.nodes_Radio.Location = new System.Drawing.Point(194, 224);
            this.nodes_Radio.Name = "nodes_Radio";
            this.nodes_Radio.Size = new System.Drawing.Size(56, 17);
            this.nodes_Radio.TabIndex = 9;
            this.nodes_Radio.TabStop = true;
            this.nodes_Radio.Text = "Nodes";
            this.nodes_Radio.UseVisualStyleBackColor = true;
            this.nodes_Radio.CheckedChanged += new System.EventHandler(this.nodes_Radio_CheckedChanged);
            // 
            // transition_Radio
            // 
            this.transition_Radio.AutoSize = true;
            this.transition_Radio.Location = new System.Drawing.Point(274, 224);
            this.transition_Radio.Name = "transition_Radio";
            this.transition_Radio.Size = new System.Drawing.Size(76, 17);
            this.transition_Radio.TabIndex = 10;
            this.transition_Radio.Text = "Transitions";
            this.transition_Radio.UseVisualStyleBackColor = true;
            this.transition_Radio.CheckedChanged += new System.EventHandler(this.transition_Radio_CheckedChanged);
            // 
            // transitions_gridview
            // 
            this.transitions_gridview.AllowUserToAddRows = false;
            this.transitions_gridview.AllowUserToDeleteRows = false;
            this.transitions_gridview.AllowUserToResizeColumns = false;
            this.transitions_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transitions_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.transitions_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transitions_gridview.BackgroundColor = System.Drawing.Color.OldLace;
            this.transitions_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitions_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.transitions_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transitions_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transition});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transitions_gridview.DefaultCellStyle = dataGridViewCellStyle8;
            this.transitions_gridview.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.transitions_gridview.Location = new System.Drawing.Point(12, 12);
            this.transitions_gridview.Name = "transitions_gridview";
            this.transitions_gridview.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitions_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.transitions_gridview.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.transitions_gridview.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.transitions_gridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitions_gridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transitions_gridview.Size = new System.Drawing.Size(176, 229);
            this.transitions_gridview.TabIndex = 11;
            this.transitions_gridview.Visible = false;
            // 
            // transition
            // 
            this.transition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transition.HeaderText = "Transitions";
            this.transition.Name = "transition";
            this.transition.ReadOnly = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 253);
            this.Controls.Add(this.transitions_gridview);
            this.Controls.Add(this.transition_Radio);
            this.Controls.Add(this.nodes_Radio);
            this.Controls.Add(this.end_checkbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.nodes_gridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nodes_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitions_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nodes_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Node;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox end_checkbox;
        private System.Windows.Forms.RadioButton nodes_Radio;
        private System.Windows.Forms.RadioButton transition_Radio;
        private System.Windows.Forms.DataGridView transitions_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn transition;
    }
}