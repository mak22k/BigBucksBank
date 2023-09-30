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
    public partial class Form7 : Form
    {
        public static Form1 form1;


        public Form7()
        {
            InitializeComponent();
            //txtReceiptDetails.Text = printText;

            string savingsName = "Savings - " + Form1.users[Form1.userIndex].getSavings().getAcctLast4(),
            checkingName = "Checking - " + Form1.users[Form1.userIndex].getChecking().getAcctLast4();

            Form1.appendOutput(String.Format("\r\n----------\r\nBalance ({0}):  " +
                "\r\nBalance ({1}): ", checkingName, savingsName), 
                //// ^^description  vvbalance
                String.Format("\r\n-----\r\n{0:c}\r\n{1:c}",
                Form1.users[Form1.userIndex].getChecking().getAcctBal(),
                Form1.users[Form1.userIndex].getSavings().getAcctBal()) ); 

            loadTextBox(txtReceiptDetails, Form1.printTextDesc);
            loadTextBox(txtReceiptMoney, Form1.printTextMoney);
            loadTextBox(txtCustNum, Form1.users[Form1.userIndex].getUserID());

            //clear receipt buffer after it prints
            Form1.printTextDesc = "";
            Form1.printTextMoney = "";

            //Form1.printText = "";
        }



        public static void loadTextBox(TextBox tb, string str)
        {
            tb.Text = str;//Form1.printText;
        }

        private void btReturnWith_Click(object sender, EventArgs e)
        {
            //Form2.acctNames.Clear();

            /*Form2.frmDeposit.Dispose();
            Form2.frmWithdraw.Dispose();
            Form2.frmCheckBal.Dispose();
            Form2.frmTransfer.Dispose();*/

            
            Form2.acctNames.Clear();
            Form2.i = -1;
            Form1.form2.Close();
            this.Hide();
            form1.Show();
        }
    }
}
