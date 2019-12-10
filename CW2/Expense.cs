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
    public partial class Expense : Form
    {

       
         
      
         
        public Expense()
        {
            InitializeComponent();
        
        }

        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-JFTC1SK;Initial Catalog=expense;Integrated Security=True");
        

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM expense";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("open data success");






        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into expense (id,amount,type,category,Date) VALUES('" + ID_TextBox.Text + "','" + Amount_textBox.Text + "','" + Type_comboBox1.Text + "','" + Category_comboBox.Text + "','" + Date_dateTimePicker.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("InsertKeyMode success");


        }

        
            private void AddExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenseDataSet.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.expenseDataSet.expense);
            // TODO: This line of code loads data into the 'expenseDataSet3.expense' table. You can move, or remove it, as needed.



        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE expense SET amount='" +Amount_textBox.Text+ "',type='" +Type_comboBox1.Text+ "',category='" + Category_comboBox.Text+ "',Date='" + Date_dateTimePicker.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit Successfully");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM expense where id = '"+ID_TextBox.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Deleted !!");
        }
    }
    }

    
    

