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
    public partial class ReportviewerForm2 : Form
    {
        public ReportviewerForm2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-JFTC1SK;Initial Catalog=expense;Integrated Security=True");

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExpenseReport_button_Click(object sender, EventArgs e)
        {
            var newForm = new ReportviewerForm();
            newForm.Show();
        }

        private void ExpenseCreateReport_button_Click(object sender, EventArgs e)
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

        private void ReportviewerForm2_Load(object sender, EventArgs e)
        {
          

        }
    }
}
