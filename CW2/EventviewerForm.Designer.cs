namespace CW2
{
    partial class Event
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.ID_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Location_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Time_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Time_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).BeginInit();

            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(484, 560);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 35);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(185, 189);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(166, 26);
            this.ID_textBox.TabIndex = 2;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(393, 194);
            this.Date_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(44, 20);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "Date";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(589, 114);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 35);
            this.Delete_button.TabIndex = 40;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(373, 114);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(112, 35);
            this.Edit_button.TabIndex = 39;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(185, 114);
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
            this.Read_button.Location = new System.Drawing.Point(809, 114);
            this.Read_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(154, 35);
            this.Read_button.TabIndex = 37;
            this.Read_button.Text = "Read database";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(119, 192);
            this.ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(26, 20);
            this.ID_label.TabIndex = 41;
            this.ID_label.Text = "ID";
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Location = new System.Drawing.Point(699, 192);
            this.Location_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(70, 20);
            this.Location_label.TabIndex = 42;
            this.Location_label.Text = "Location";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            // 
            // eventDataSet
            // 
            // 
            // Location_comboBox1
            // 
            this.Location_comboBox1.FormattingEnabled = true;
            this.Location_comboBox1.Items.AddRange(new object[] {
            "London",
            "Oxford",
            "Cambridge",
            "Bristol",
            "Bournemouth",
            "Brighton",
            "Sussex",
            "Essex",
            "Scotland",
            "Cornwall",
            "Leeds"});
            this.Location_comboBox1.Location = new System.Drawing.Point(809, 189);
            this.Location_comboBox1.Name = "Location_comboBox1";
            this.Location_comboBox1.Size = new System.Drawing.Size(152, 28);
            this.Location_comboBox1.TabIndex = 53;
            // 
            // eventTableAdapter
            // 
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(393, 285);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 54;
            this.Name.Text = "Name";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(484, 285);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(166, 26);
            this.Name_textBox.TabIndex = 55;
            // 
            // Time_dateTimePicker
            // 
            this.Time_dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.Time_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_dateTimePicker.Location = new System.Drawing.Point(461, 194);
            this.Time_dateTimePicker.Name = "Time_dateTimePicker";
            this.Time_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.Time_dateTimePicker.TabIndex = 56;
            // 
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataMember = "Event";
            // 
            // eventDataSet2
            // 

            // 
            // eventTableAdapter1
            // 
            // 
            // Time_dateTimePicker1
            // 
            this.Time_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_dateTimePicker1.Location = new System.Drawing.Point(794, 286);
            this.Time_dateTimePicker1.Name = "Time_dateTimePicker1";
            this.Time_dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.Time_dateTimePicker1.TabIndex = 58;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Time_label.Location = new System.Drawing.Point(725, 291);
            this.Time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(43, 20);
            this.Time_label.TabIndex = 60;
            this.Time_label.Text = "Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.eventBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(95, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(899, 158);
            this.dataGridView1.TabIndex = 61;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn1
            // 
            this.locationDataGridViewTextBoxColumn1.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn1.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // eventBindingSource2
            // 
            this.eventBindingSource2.DataMember = "Event";
            // 
            // eventDataSet3
            // 

            // 
            // eventTableAdapter2
            // 

            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Time_dateTimePicker1);
            this.Controls.Add(this.Time_dateTimePicker);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Location_comboBox1);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Cancel_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "EventviewerForm";
            this.Load += new System.EventHandler(this.Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.ComboBox Location_comboBox1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.DateTimePicker Time_dateTimePicker;
        private System.Windows.Forms.BindingSource eventBindingSource1;
        private System.Windows.Forms.DateTimePicker Time_dateTimePicker1;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eventBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
    }
}