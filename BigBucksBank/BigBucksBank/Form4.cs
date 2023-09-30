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
    public partial class Form4 : Form // withdrawal
    {
        decimal newBal, transactionAmt;
        int selectedAcct;
        Form2 form2 = Form1.form2;

        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Add(Form2.acctNames[0]);
            comboBox1.Items.Add(Form2.acctNames[1]);
        }

        private void btReturnWith_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void btCalcWithdraw_Click(object sender, EventArgs e)
        {
            if (Validator.IsSelected(comboBox1) && Validator.IsDecimal(txtAmtWith))
            {
                selectedAcct = comboBox1.SelectedIndex;
                transactionAmt = Decimal.Parse(txtAmtWith.Text);

                if (selectedAcct == 0)
                {
                    if (Validator.IsWithinRange(txtAmtWith, 0m, Form1.users[Form2.i].getChecking().getAcctBal()))
                    {
                        Form1.users[Form2.i].getChecking().withdraw(transactionAmt);
                        newBal = Form1.users[Form2.i].getChecking().getAcctBal();
                        Form1.appendOutput(String.Format("Withdrawal from {0}:\r\n", comboBox1.SelectedItem.ToString()),
                            String.Format("{0:c}\r\n", transactionAmt));
                    }
                }
                if (selectedAcct == 1)//// MAKE SURE TO CHECK THAT WE CAN WITHDRAW
                {
                    if (Validator.IsWithinRange(txtAmtWith, 0m, Form1.users[Form2.i].getSavings().getAcctBal()))
                    {
                        Form1.users[Form2.i].getSavings().withdraw(transactionAmt);
                        newBal = Form1.users[Form2.i].getSavings().getAcctBal();
                        Form1.appendOutput(String.Format("Withdrawal from {0}:\r\n", comboBox1.SelectedItem.ToString()),
                            String.Format("{0:c}\r\n", transactionAmt));
                    }
                }

                txtBalWith.Text = String.Format("{0:c}", newBal);

            }
        }
    }
}