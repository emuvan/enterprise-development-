namespace CW2
{
    partial class ReportviewerForm2
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
            this.ExpenseCreateReport_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.IncomeReport_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseCreateReport_button
            // 
            this.ExpenseCreateReport_button.Location = new System.Drawing.Point(471, 78);
            this.ExpenseCreateReport_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpenseCreateReport_button.Name = "ExpenseCreateReport_button";
            this.ExpenseCreateReport_button.Size = new System.Drawing.Size(198, 35);
            this.ExpenseCreateReport_button.TabIndex = 2;
            this.ExpenseCreateReport_button.Text = "Create Report Expense";
            this.ExpenseCreateReport_button.UseVisualStyleBackColor = true;
            this.ExpenseCreateReport_button.Click += new System.EventHandler(this.ExpenseCreateReport_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(507, 1164);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(198, 35);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // IncomeReport_button
            // 
            this.IncomeReport_button.Location = new System.Drawing.Point(185, 1164);
            this.IncomeReport_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomeReport_button.Name = "IncomeReport_button";
            this.IncomeReport_button.Size = new System.Drawing.Size(198, 35);
            this.IncomeReport_button.TabIndex = 4;
            this.IncomeReport_button.Text = "Income Report";
            this.IncomeReport_button.UseVisualStyleBackColor = true;
            this.IncomeReport_button.Click += new System.EventHandler(this.ExpenseReport_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.expenseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(994, 990);
            this.dataGridView1.TabIndex = 5;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            // 
            // ReportviewerForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 1239);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IncomeReport_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.ExpenseCreateReport_button);
            this.Name = "ReportviewerForm2";
            this.Text = "ReportviewerForm2";
            this.Load += new System.EventHandler(this.ReportviewerForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExpenseCreateReport_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button IncomeReport_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}