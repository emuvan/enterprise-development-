namespace CW2
{
    partial class ReportviewerForm
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
            this.IncomeCreateReport_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.incomeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeCreateReport_button
            // 
            this.IncomeCreateReport_button.Location = new System.Drawing.Point(508, 42);
            this.IncomeCreateReport_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomeCreateReport_button.Name = "IncomeCreateReport_button";
            this.IncomeCreateReport_button.Size = new System.Drawing.Size(198, 35);
            this.IncomeCreateReport_button.TabIndex = 1;
            this.IncomeCreateReport_button.Text = "Create Report Income";
            this.IncomeCreateReport_button.UseVisualStyleBackColor = true;
            this.IncomeCreateReport_button.Click += new System.EventHandler(this.CreateReport_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(537, 1004);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(198, 35);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // incomeDataSet
            // 

            // 
            // incomeDataSetBindingSource
            // 
            this.incomeDataSetBindingSource.Position = 0;
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
            this.dataGridView1.DataSource = this.incomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(210, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(882, 785);
            this.dataGridView1.TabIndex = 60;
            // 
            // incomeDataSet1
            // 

            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
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
            // Expense_button
            // 
            this.Expense_button.Location = new System.Drawing.Point(998, 986);
            this.Expense_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Expense_button.Name = "Expense_button";
            this.Expense_button.Size = new System.Drawing.Size(198, 35);
            this.Expense_button.TabIndex = 61;
            this.Expense_button.Text = "Expense Report";
            this.Expense_button.UseVisualStyleBackColor = true;
            this.Expense_button.Click += new System.EventHandler(this.Expense_button_Click);
            // 
            // ReportviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 1079);
            this.Controls.Add(this.Expense_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.IncomeCreateReport_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportviewerForm";
            this.Text = "ReportviewerForm";
            this.Load += new System.EventHandler(this.ReportviewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IncomeCreateReport_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.BindingSource incomeDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Expense_button;
    }
}