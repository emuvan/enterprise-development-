namespace CW2
{
    partial class ContactviewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new CW2.datasets_folder.ContactDataSet();
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new CW2.datasets_folder.ContactDataSetTableAdapters.ContactTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please fill out for the contact";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(446, 579);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(184, 35);
            this.Cancel_Button.TabIndex = 17;
            this.Cancel_Button.Text = "cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(584, 211);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 35);
            this.Delete_button.TabIndex = 50;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(368, 211);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(112, 35);
            this.Edit_button.TabIndex = 49;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(179, 211);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 35);
            this.Add_button.TabIndex = 48;
            this.Add_button.Text = "Add ";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(803, 211);
            this.Read_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(154, 35);
            this.Read_button.TabIndex = 47;
            this.Read_button.Text = "Read database";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(141, 287);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 54;
            this.ID.Text = "ID";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(218, 284);
            this.ID_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(148, 26);
            this.ID_TextBox.TabIndex = 53;
            // 
            // PhoneNumber_textBox
            // 
            this.PhoneNumber_textBox.Location = new System.Drawing.Point(823, 287);
            this.PhoneNumber_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            this.PhoneNumber_textBox.Size = new System.Drawing.Size(148, 26);
            this.PhoneNumber_textBox.TabIndex = 52;
            // 
            // PhoneNumber_label
            // 
            this.PhoneNumber_label.AutoSize = true;
            this.PhoneNumber_label.Location = new System.Drawing.Point(683, 289);
            this.PhoneNumber_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumber_label.Name = "PhoneNumber_label";
            this.PhoneNumber_label.Size = new System.Drawing.Size(111, 20);
            this.PhoneNumber_label.TabIndex = 51;
            this.PhoneNumber_label.Text = "PhoneNumber";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(507, 287);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(148, 26);
            this.Name_textBox.TabIndex = 55;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(421, 287);
            this.Name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(51, 20);
            this.Name_label.TabIndex = 56;
            this.Name_label.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.contactBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(179, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(720, 168);
            this.dataGridView1.TabIndex = 57;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataMember = "Contact";
            this.contactBindingSource1.DataSource = this.contactDataSet;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Phonenumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phonenumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ContactviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.PhoneNumber_textBox);
            this.Controls.Add(this.PhoneNumber_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactviewerForm";
            this.Text = "ContactviewerForm";
            this.Load += new System.EventHandler(this.ContactviewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.TextBox PhoneNumber_textBox;
        private System.Windows.Forms.Label PhoneNumber_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private datasets_folder.ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private datasets_folder.ContactDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}