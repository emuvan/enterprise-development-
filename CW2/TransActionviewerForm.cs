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
    public partial class TransActionviewerForm : Form
    {
        public TransActionviewerForm()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddIncome_button_Click(object sender, EventArgs e)
        {
            var newForm = new Income();
            newForm.Show();
        }

        private void Expense_Button_Click(object sender, EventArgs e)
        {
            
                var newForm = new Expense();
                newForm.Show();
        }
    }
}
