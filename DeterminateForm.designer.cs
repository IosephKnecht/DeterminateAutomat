namespace WindowsFormsApp16
{
    partial class DeterminateForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new System.Windows.Forms.DataGridView();
            this.start_node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_comboBox = new System.Windows.Forms.ComboBox();
            this.trans_comboBox = new System.Windows.Forms.ComboBox();
            this.final_comboBox = new System.Windows.Forms.ComboBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.current_start_node = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackgroundColor = System.Drawing.Color.OldLace;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start_node,
            this.transition,
            this.final_node});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle8;
            this.table.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.table.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.table.Size = new System.Drawing.Size(317, 297);
            this.table.TabIndex = 12;
            // 
            // start_node
            // 
            this.start_node.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_node.HeaderText = "start_node";
            this.start_node.Name = "start_node";
            this.start_node.ReadOnly = true;
            // 
            // transition
            // 
            this.transition.HeaderText = "transition";
            this.transition.Name = "transition";
            this.transition.ReadOnly = true;
            // 
            // final_node
            // 
            this.final_node.HeaderText = "final_node";
            this.final_node.Name = "final_node";
            this.final_node.ReadOnly = true;
            // 
            // start_comboBox
            // 
            this.start_comboBox.FormattingEnabled = true;
            this.start_comboBox.Location = new System.Drawing.Point(351, 30);
            this.start_comboBox.Name = "start_comboBox";
            this.start_comboBox.Size = new System.Drawing.Size(121, 21);
            this.start_comboBox.TabIndex = 13;
            // 
            // trans_comboBox
            // 
            this.trans_comboBox.FormattingEnabled = true;
            this.trans_comboBox.Location = new System.Drawing.Point(351, 72);
            this.trans_comboBox.Name = "trans_comboBox";
            this.trans_comboBox.Size = new System.Drawing.Size(121, 21);
            this.trans_comboBox.TabIndex = 14;
            // 
            // final_comboBox
            // 
            this.final_comboBox.FormattingEnabled = true;
            this.final_comboBox.Location = new System.Drawing.Point(351, 111);
            this.final_comboBox.Name = "final_comboBox";
            this.final_comboBox.Size = new System.Drawing.Size(121, 21);
            this.final_comboBox.TabIndex = 15;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(335, 178);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(156, 23);
            this.OK_button.TabIndex = 19;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(335, 233);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(416, 148);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 17;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(335, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(335, 262);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(156, 47);
            this.set_button.TabIndex = 20;
            this.set_button.Text = "Settings";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // current_start_node
            // 
            this.current_start_node.FormattingEnabled = true;
            this.current_start_node.Location = new System.Drawing.Point(351, 206);
            this.current_start_node.Name = "current_start_node";
            this.current_start_node.Size = new System.Drawing.Size(121, 21);
            this.current_start_node.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "start_node";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "transition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "final_node";
            // 
            // DeterminateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.current_start_node);
            this.Controls.Add(this.set_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.final_comboBox);
            this.Controls.Add(this.trans_comboBox);
            this.Controls.Add(this.start_comboBox);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeterminateForm";
            this.Text = "DeterminateForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_node;
        private System.Windows.Forms.DataGridViewTextBoxColumn transition;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_node;
        private System.Windows.Forms.ComboBox start_comboBox;
        private System.Windows.Forms.ComboBox trans_comboBox;
        private System.Windows.Forms.ComboBox final_comboBox;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.ComboBox current_start_node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

