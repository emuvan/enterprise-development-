namespace CW2
{
    partial class TransActionviewerForm
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Transaction_Label = new System.Windows.Forms.Label();
            this.Expense_Button = new System.Windows.Forms.Button();
            this.Income_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(337, 352);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(123, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Transaction_Label
            // 
            this.Transaction_Label.AutoSize = true;
            this.Transaction_Label.Location = new System.Drawing.Point(280, 75);
            this.Transaction_Label.Name = "Transaction_Label";
            this.Transaction_Label.Size = new System.Drawing.Size(234, 13);
            this.Transaction_Label.TabIndex = 14;
            this.Transaction_Label.Text = "Click on the following buttion for the Transaction";
            // 
            // Expense_Button
            // 
            this.Expense_Button.Location = new System.Drawing.Point(132, 197);
            this.Expense_Button.Name = "Expense_Button";
            this.Expense_Button.Size = new System.Drawing.Size(208, 80);
            this.Expense_Button.TabIndex = 11;
            this.Expense_Button.Text = "Expense";
            this.Expense_Button.UseVisualStyleBackColor = true;
            this.Expense_Button.Click += new System.EventHandler(this.Expense_Button_Click);
            // 
            // Income_button
            // 
            this.Income_button.Location = new System.Drawing.Point(401, 197);
            this.Income_button.Name = "Income_button";
            this.Income_button.Size = new System.Drawing.Size(208, 80);
            this.Income_button.TabIndex = 8;
            this.Income_button.Text = "Income";
            this.Income_button.UseVisualStyleBackColor = true;
            this.Income_button.Click += new System.EventHandler(this.AddIncome_button_Click);
            // 
            // TransActionviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Transaction_Label);
            this.Controls.Add(this.Expense_Button);
            this.Controls.Add(this.Income_button);
            this.Name = "TransActionviewerForm";
            this.Text = "TransActionviewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Transaction_Label;
        private System.Windows.Forms.Button Expense_Button;
        private System.Windows.Forms.Button Income_button;
    }
}