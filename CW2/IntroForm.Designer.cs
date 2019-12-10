namespace CW2
{
    partial class IntroForm
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
            this.Report_Button = new System.Windows.Forms.Button();
            this.Contact_Button = new System.Windows.Forms.Button();
            this.Transaction_Button = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Report_Button
            // 
            this.Report_Button.Location = new System.Drawing.Point(382, 223);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(123, 23);
            this.Report_Button.TabIndex = 5;
            this.Report_Button.Text = "Report";
            this.Report_Button.UseVisualStyleBackColor = true;
            this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
            // 
            // Contact_Button
            // 
            this.Contact_Button.Location = new System.Drawing.Point(382, 132);
            this.Contact_Button.Name = "Contact_Button";
            this.Contact_Button.Size = new System.Drawing.Size(123, 23);
            this.Contact_Button.TabIndex = 4;
            this.Contact_Button.Text = "Contact";
            this.Contact_Button.UseVisualStyleBackColor = true;
            this.Contact_Button.Click += new System.EventHandler(this.Contact_Button_Click);
            // 
            // Transaction_Button
            // 
            this.Transaction_Button.Location = new System.Drawing.Point(170, 132);
            this.Transaction_Button.Name = "Transaction_Button";
            this.Transaction_Button.Size = new System.Drawing.Size(123, 23);
            this.Transaction_Button.TabIndex = 3;
            this.Transaction_Button.Text = "Transaction";
            this.Transaction_Button.UseVisualStyleBackColor = true;
            this.Transaction_Button.Click += new System.EventHandler(this.Transaction_Button_Click);
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(170, 223);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(123, 23);
            this.Event.TabIndex = 6;
            this.Event.Text = "Event";
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(276, 356);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 7;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.Report_Button);
            this.Controls.Add(this.Contact_Button);
            this.Controls.Add(this.Transaction_Button);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Button Contact_Button;
        private System.Windows.Forms.Button Transaction_Button;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.Button Close_Button;
    }
}

