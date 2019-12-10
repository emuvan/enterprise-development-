using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {

        }

        private void Transaction_Button_Click(object sender, EventArgs e)
        {
            var newForm = new TransActionviewerForm();
            newForm.Show();
        }

        private void Contact_Button_Click(object sender, EventArgs e)
        {
            var newForm = new ContactviewerForm();
            newForm.Show();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            var newForm = new ReportviewerForm();
            newForm.Show();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
