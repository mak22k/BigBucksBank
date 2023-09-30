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
    public partial class Form3 : Form // Deposit form
    {
        decimal newBal, transactionAmt;
        int selectedAcct;
        Form2 form2 = Form1.form2;

        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add(Form2.acctNames[0]);
            comboBox1.Items.Add(Form2.acctNames[1]);
        }

        private void btReturnDep_Click(object sender, EventArgs e)
        {
            this.Close();
            form2.Show();
        }

        private void btCalcDep_Click(object sender, EventArgs e)
        {
            if (Validator.IsSelected(comboBox1) && Validator.IsDecimal(txtAmtDep))
            {
                selectedAcct = comboBox1.SelectedIndex;            
                transactionAmt = Decimal.Parse(txtAmtDep.Text);

                if (selectedAcct == 0) {
                    Form1.users[Form2.i].getChecking().deposit(transactionAmt);
                    newBal = Form1.users[Form2.i].getChecking().getAcctBal();
                }
                if (selectedAcct == 1) {
                    Form1.users[Form2.i].getSavings().deposit(transactionAmt);
                    newBal = Form1.users[Form2.i].getSavings().getAcctBal();
                }

                txtBalDep.Text = String.Format("{0:c}", newBal);
                //Form7.printText = String.Format("{0}: {1:c}", comboBox1.SelectedItem.ToString(), newBal);
                //Form1.appendOutput(String.Format("{0,-50} {1,50} {2,7:c}\r\n", "Deposit in " , comboBox1.SelectedItem.ToString() + ": ", transactionAmt));
                //Form1.appendOutput(String.Format("{0,-80}  {1,15:c}\r\n", "Deposit in " + comboBox1.SelectedItem.ToString() + ": ", transactionAmt));
                Form1.appendOutput(String.Format("Deposit in {0}:\r\n", comboBox1.SelectedItem.ToString()),
                    String.Format("{0:c}\r\n", transactionAmt));
            }
        }
    }
}
