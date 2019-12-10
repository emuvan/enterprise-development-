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
    public partial class ContactviewerForm : Form
    {
        public ContactviewerForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-JFTC1SK;Initial Catalog=Contact;Integrated Security=True");

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into Contact (id,Name,Phonenumber) VALUES('" + ID_TextBox.Text + "','" + Name_textBox.Text + "','" + PhoneNumber_textBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("InsertKeyMode success");
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Contact SET Name='" + Name_textBox.Text + "',Phonenumber='" + PhoneNumber_textBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit Successfully");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM Contact where id = '" + ID_TextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Deleted !!");
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Contact";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("open data success");
        }

        private void ContactviewerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.contactDataSet.Contact);


        }
    }
}
