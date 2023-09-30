using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class Form5 : Form
    {
        int selectedAcct;
        decimal bal;
        Form2 form2 = Form1.form2;

        public Form5()
        {
            InitializeComponent();
            comboBox1.Items.Add(Form2.acctNames[0]);
            comboBox1.Items.Add(Form2.acctNames[1]);
        }


        private void btGetBal_Click(object sender, EventArgs e)
        {
            if (Validator.IsSelected(comboBox1))
            {
                selectedAcct = comboBox1.SelectedIndex;

                switch (selectedAcct)
                {
                    case 0: bal = Form1.users[Form2.i].getChecking().getAcctBal(); break;
                    case 1: bal = Form1.users[Form2.i].getSavings().getAcctBal(); break;
                }

                txtBalBal.Text = String.Format("{0:c}", bal);
            }
        }

        private void btReturnBal_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }
}