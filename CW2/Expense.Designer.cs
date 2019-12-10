namespace CW2
{
    partial class Expense
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.AddIncome_label = new System.Windows.Forms.Label();
            this.expenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Read_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.expenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Type_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Category_label = new System.Windows.Forms.Label();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expenseBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseDataSet = new CW2.expenseDataSet();
            this.expenseBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableAdapter = new CW2.expenseDataSetTableAdapters.expenseTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(492, 624);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(184, 35);
            this.Cancel_Button.TabIndex = 24;
            this.Cancel_Button.Text = "cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddIncome_label
            // 
            this.AddIncome_label.AutoSize = true;
            this.AddIncome_label.Location = new System.Drawing.Point(456, 85);
            this.AddIncome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddIncome_label.Name = "AddIncome_label";
            this.AddIncome_label.Size = new System.Drawing.Size(259, 20);
            this.AddIncome_label.TabIndex = 19;
            this.AddIncome_label.Text = "please fill out the detail for Expense";
            // 
            // expenseBindingSource2
            // 
            this.expenseBindingSource2.DataMember = "expense";
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(822, 154);
            this.Read_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(154, 35);
            this.Read_button.TabIndex = 27;
            this.Read_button.Text = "Read database";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(198, 154);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 35);
            this.Add_button.TabIndex = 28;
            this.Add_button.Text = "Add ";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(382, 265);
            this.Amount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(63, 20);
            this.Amount_label.TabIndex = 29;
            this.Amount_label.Text = "amount";
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(492, 260);
            this.Amount_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(148, 26);
            this.Amount_textBox.TabIndex = 30;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(741, 265);
            this.Type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(39, 20);
            this.Type_label.TabIndex = 31;
            this.Type_label.Text = "type";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(148, 258);
            this.ID_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(148, 26);
            this.ID_TextBox.TabIndex = 33;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(72, 262);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 34;
            this.ID.Text = "ID";
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(387, 154);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(112, 35);
            this.Edit_button.TabIndex = 35;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(603, 154);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 35);
            this.Delete_button.TabIndex = 36;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // expenseBindingSource1
            // 
            this.expenseBindingSource1.DataMember = "expense";
            // 
            // Type_comboBox1
            // 
            this.Type_comboBox1.FormattingEnabled = true;
            this.Type_comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Recurring"});
            this.Type_comboBox1.Location = new System.Drawing.Point(822, 265);
            this.Type_comboBox1.Name = "Type_comboBox1";
            this.Type_comboBox1.Size = new System.Drawing.Size(152, 28);
            this.Type_comboBox1.TabIndex = 37;
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(383, 328);
            this.Category_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(70, 20);
            this.Category_label.TabIndex = 38;
            this.Category_label.Text = "category";
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Items.AddRange(new object[] {
            "Food",
            "Entertainment",
            "Cosmetics",
            "electronics",
            "membership subrcrition",
            "electronics"});
            this.Category_comboBox.Location = new System.Drawing.Point(488, 325);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(152, 28);
            this.Category_comboBox.TabIndex = 40;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            // 
            // expenseBindingSource3
            // 
            this.expenseBindingSource3.DataMember = "expense";
            // 
            // Date_dateTimePicker
            // 
            this.Date_dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_dateTimePicker.Location = new System.Drawing.Point(776, 328);
            this.Date_dateTimePicker.Name = "Date_dateTimePicker";
            this.Date_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.Date_dateTimePicker.TabIndex = 58;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(708, 328);
            this.Date_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(44, 20);
            this.Date_Label.TabIndex = 57;
            this.Date_Label.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.expenseBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(39, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(993, 194);
            this.dataGridView1.TabIndex = 59;
            // 
            // expenseBindingSource4
            // 
            this.expenseBindingSource4.DataMember = "expense";
            // 
            // expenseDataSet
            // 
            this.expenseDataSet.DataSetName = "expenseDataSet";
            this.expenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseBindingSource5
            // 
            this.expenseBindingSource5.DataMember = "expense";
            this.expenseBindingSource5.DataSource = this.expenseDataSet;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn6.HeaderText = "type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn7.HeaderText = "category";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Date_dateTimePicker);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.Category_label);
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
            this.Name = "Expense";
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label AddIncome_label;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.BindingSource expenseBindingSource1;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ComboBox Type_comboBox1;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.BindingSource expenseBindingSource2;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource expenseBindingSource3;
        private System.Windows.Forms.DateTimePicker Date_dateTimePicker;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expenseBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private expenseDataSet expenseDataSet;
        private System.Windows.Forms.BindingSource expenseBindingSource5;
        private expenseDataSetTableAdapters.expenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}