using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CW2
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-JFTC1SK;Initial Catalog=Event;Integrated Security=True");


        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into Event (ID,Date,Location,Name,Time) VALUES('" + ID_textBox.Text + "','" + Time_dateTimePicker.Text + "','" + Location_comboBox1.Text + "','" + Name_textBox.Text + "','" + Time_dateTimePicker1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("InsertKeyMode success");
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Event SET Date='" + Time_dateTimePicker.Text + "',Location='" + Location_comboBox1.Text + "',Name='" + Name_textBox.Text + "',Time='" + Time_dateTimePicker1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit Successfully");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM Event where id = '" + ID_textBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Event Deleted !!");
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Event";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("open data success");
        }

        private void Event_Load(object sender, EventArgs e)
        {
   

        }
    }
}
