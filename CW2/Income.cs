using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CW2
{
    public partial class Income : Form
    {
        
        public Income()
        {
            InitializeComponent();
          
        }

        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-JFTC1SK;Initial Catalog=Income;Integrated Security=True");


        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

 

        private void Add_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into Income (id,amount,type,Date) VALUES('" + ID_TextBox.Text + "','" + Amount_textBox.Text + "','" + Type_comboBox1.Text + "','" + Date_dateTimePicker.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("InsertKeyMode success");
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Income SET amount='" + Amount_textBox.Text + "',type='" + Type_comboBox1.Text + "',Date='" + Date_dateTimePicker.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit Successfully");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM Income where id = '" + ID_TextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Deleted !!");
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Income";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("open data success");
        }

        private void Income_Load(object sender, EventArgs e)
        {
            


        }
    }
}
