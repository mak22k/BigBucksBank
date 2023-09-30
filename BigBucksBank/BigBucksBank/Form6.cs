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
    public partial class Form6 : Form // transfer form
    {
        bool everythingIsFine = false;
        int selectedAcct;
        decimal newBalFrom, newBalTo, transactionAmt;
        Form2 form2 = Form1.form2;

        public Form6()
        {
            InitializeComponent();

            cbFrom.Items.Add(Form2.acctNames[0]);
            cbFrom.Items.Add(Form2.acctNames[1]);

            cbTo.Items.Add(Form2.acctNames[0]);
            cbTo.Items.Add(Form2.acctNames[1]);
        }




        private void btCalcTransfer_Click(object sender, EventArgs e)
        {
            if (!(Validator.IsDifferentAccount(cbFrom, cbTo)))
                return;
            
            //withdraw section
            if (Validator.IsSelected(cbFrom) && Validator.IsDecimal(txtAmtTransfer))
            {
                selectedAcct = cbFrom.SelectedIndex;
                transactionAmt = Decimal.Parse(txtAmtTransfer.Text);

                if (selectedAcct == 0)
                {
                    if (Validator.IsWithinRange(txtAmtTransfer, 0m, Form1.users[Form2.i].getChecking().getAcctBal()))
                    {
                        Form1.users[Form2.i].getChecking().withdraw(transactionAmt);
                        newBalFrom = Form1.users[Form2.i].getChecking().getAcctBal();
                        everythingIsFine = true;
                    }
                }
                if (selectedAcct == 1)//// MAKE SURE TO CHECK THAT WE CAN WITHDRAW
                {
                    if (Validator.IsWithinRange(txtAmtTransfer, 0m, Form1.users[Form2.i].getSavings().getAcctBal()))
                    {
                        Form1.users[Form2.i].getSavings().withdraw(transactionAmt);
                        newBalFrom = Form1.users[Form2.i].getSavings().getAcctBal();
                        everythingIsFine = true;
                    }
                }
               /* if(everythingIsFine)
                    txtSourceBal.Text = String.Format("{0:c}", newBalFrom);*/

                // end withdraw                
            }
            // begin deposit section

            if (Validator.IsSelected(cbTo) && everythingIsFine) // already tested that the transfer amt is numeric
            {
                selectedAcct = cbTo.SelectedIndex;
                transactionAmt = Decimal.Parse(txtAmtTransfer.Text);

                if (selectedAcct == 0)
                {
                    Form1.users[Form2.i].getChecking().deposit(transactionAmt);
                    newBalTo = Form1.users[Form2.i].getChecking().getAcctBal();
                }
                if (selectedAcct == 1)
                {
                    Form1.users[Form2.i].getSavings().deposit(transactionAmt);
                    newBalTo = Form1.users[Form2.i].getSavings().getAcctBal();
                }

                //txtDestBal.Text = String.Format("{0:c}", newBalTo);
                // end deposit section

                Form1.appendOutput(String.Format("Transfer from {0} to {1}:\r\n", cbFrom.SelectedItem.ToString(),
                        cbTo.SelectedItem.ToString()), String.Format("{0:c}\r\n", transactionAmt));
                txtSourceBal.Text = String.Format("{0:c}", newBalFrom);
                txtDestBal.Text = String.Format("{0:c}", newBalTo);
            }

            


            if (everythingIsFine)
            {
    /*            Form1.appendOutput(String.Format("Transfer from {0} to {1}:\r\n", cbFrom.SelectedItem.ToString(),
                    cbTo.SelectedItem.ToString()), String.Format("{0:c}\r\n", transactionAmt));
                txtSourceBal.Text = String.Format("{0:c}", newBalFrom);
                txtDestBal.Text = String.Format("{0:c}", newBalTo);*/
            }

        }

        private void btReturnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }






        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
