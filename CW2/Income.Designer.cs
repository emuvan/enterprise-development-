namespace CW2
{
    partial class Income
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
            this.components = new System.ComponentModel.Container();
            this.AddIncome_label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Type_comboBox1 = new System.Windows.Forms.ComboBox();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_Label = new System.Windows.Forms.Label();
            this.incomeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.incomeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddIncome_label
            // 
            this.AddIncome_label.AutoSize = true;
            this.AddIncome_label.Location = new System.Drawing.Point(458, 132);
            this.AddIncome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddIncome_label.Name = "AddIncome_label";
            this.AddIncome_label.Size = new System.Drawing.Size(256, 20);
            this.AddIncome_label.TabIndex = 5;
            this.AddIncome_label.Text = "please fill out the detail for incomes";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(508, 618);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(184, 35);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(610, 211);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 35);
            this.Delete_button.TabIndex = 46;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(394, 211);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(112, 35);
            this.Edit_button.TabIndex = 45;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(111, 326);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 44;
            this.ID.Text = "ID";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(188, 323);
            this.ID_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(148, 26);
            this.ID_TextBox.TabIndex = 43;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(780, 329);
            this.Type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(39, 20);
            this.Type_label.TabIndex = 41;
            this.Type_label.Text = "type";
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(531, 324);
            this.Amount_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(148, 26);
            this.Amount_textBox.TabIndex = 40;
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(422, 329);
            this.Amount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(63, 20);
            this.Amount_label.TabIndex = 39;
            this.Amount_label.Text = "amount";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(205, 211);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 35);
            this.Add_button.TabIndex = 38;
            this.Add_button.Text = "Add ";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(829, 211);
            this.Read_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(154, 35);
            this.Read_button.TabIndex = 37;
            this.Read_button.Text = "Read database";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Type_comboBox1
            // 
            this.Type_comboBox1.FormattingEnabled = true;
            this.Type_comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Recurring"});
            this.Type_comboBox1.Location = new System.Drawing.Point(863, 329);
            this.Type_comboBox1.Name = "Type_comboBox1";
            this.Type_comboBox1.Size = new System.Drawing.Size(152, 28);
            this.Type_comboBox1.TabIndex = 52;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            // 
            // Date_dateTimePicker
            // 
            this.Date_dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_dateTimePicker.Location = new System.Drawing.Point(492, 367);
            this.Date_dateTimePicker.Name = "Date_dateTimePicker";
            this.Date_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.Date_dateTimePicker.TabIndex = 58;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(424, 367);
            this.Date_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(44, 20);
            this.Date_Label.TabIndex = 57;
            this.Date_Label.Text = "Date";
            // 
            // incomeBindingSource1
            // 
            this.incomeBindingSource1.DataMember = "Income";
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";

            // 
            // expenseDataSet4
            // 

            // 
            // expenseTableAdapter
            // 

            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incomeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(132, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(882, 139);
            this.dataGridView1.TabIndex = 59;
            // 
            // incomeDataSet
            // 

            // 
            // incomeBindingSource2
            // 
            this.incomeBindingSource2.DataMember = "Income";

            // 
            // incomeTableAdapter
            // 

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Date_dateTimePicker);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Type_comboBox1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.Amount_textBox);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.AddIncome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddIncome_label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.ComboBox Type_comboBox1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.DateTimePicker Date_dateTimePicker;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.BindingSource incomeBindingSource1;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource incomeBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}