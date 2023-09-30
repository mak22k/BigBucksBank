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
    public partial class Form2 : Form
    {
        public static int i;// = Form1.userIndex;
        public static Form3 frmDeposit;
        public static Form4 frmWithdraw;
        public static Form5 frmCheckBal;
        public static Form6 frmTransfer;
        public static Form7 frmReceipt;

        public static List<string> acctNames = new List<string>();
        public static string savingsName, checkingName;

        private void radioButton1_Click(object sender, EventArgs e)
        {
            frmDeposit = new Form3();
            this.Hide();
            frmDeposit.Show();
            frmDeposit.Focus();
        }

        private void rbWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw = new Form4();
            this.Hide();
            frmWithdraw.Show();
            frmWithdraw.Focus();
        }

        private void rbBalance_Click(object sender, EventArgs e)
        {
            frmCheckBal = new Form5();
            this.Hide();
            frmCheckBal.Show();
            frmCheckBal.Focus();
        }

        private void rbTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer = new Form6();
            this.Hide();
            frmTransfer.Show();
            frmTransfer.Focus();
        }

        private void rbExit_Click(object sender, EventArgs e)
        {
            frmReceipt = new Form7();

            //this.Hide();
            this.Close();
            frmReceipt.Show();
            frmReceipt.Focus();
        }

        public Form2()
        {
            InitializeComponent();
            //label2.Focus();
            i = Form1.userIndex;

            savingsName = "Savings - " + Form1.users[i].getSavings().getAcctLast4();
            checkingName = "Checking - " + Form1.users[i].getChecking().getAcctLast4();

            acctNames.Add(checkingName);
            acctNames.Add(savingsName);


        }



    }
}
