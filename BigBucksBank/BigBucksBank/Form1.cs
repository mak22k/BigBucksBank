using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class Form1 : Form
    {
        bool lockedOut = false;
        public string userName, pw;
        public static int userIndex = -1; //nonindex until user is found
        public static Customer LoggedInCustomer;
        public static List<Customer> users = new List<Customer>();
        public static Form2 form2;
        
        // ?? vv
        //public static string printText = "apples";//"";
        public static string printTextDesc = "";
        public static string printTextMoney = "";

        public Form1()
        {
            InitializeComponent();
            txtUserID.Focus();
            users.Add(new Customer("admin", "0000", "00000000", 0m, "10000000", 0m));
            users.Add(new Customer("admin", "bye", "20000000", 0m, "30000000", 0m));
            users.Add(new Customer("A1234567", "1111", "00000001", 500m, "00000002", 1000m));
            users.Add(new Customer("B1234567", "1111", "00000055", 5000m, "000000056", 100m));

        }

        public static void appendOutput(string strDes, string strMoney = "")
        {
            printTextDesc += strDes;
            printTextMoney += strMoney;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserID.Focus();
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
            txtMessage.Text = "";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (lockedOut &&
                (txtUserID.Text).Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                btLogin.Show();
                btClear.Show();
                //txtMessage.Text = "Admin can log in!";
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool foundUser = false;
            //int userIndex = -1; // nonindex until found
            if (!(Validator.IsPresent(txtUserID) && Validator.IsPresent(txtPassword)))
                return; // short-circuit out/cancel login if fields are empty


          

            if ((txtUserID.Text).Equals("admin", StringComparison.OrdinalIgnoreCase)
                ||
                (!lockedOut && Validator.IsAlphanumeric(txtUserID) 
                && Validator.IsCorrectNumDigits(txtUserID) 
                && Validator.IsNumeric(txtPassword)
                && Validator.IsCorrectNumDigits(txtPassword, 4)))
            {
                //Validator.incrementAttempts();
                userName = txtUserID.Text;
                pw = txtPassword.Text;
                
                foreach (Customer x in users)
                {
                    if (userName.Equals(x.getUserID(), StringComparison.OrdinalIgnoreCase)
                        && pw.Equals(x.getPassword()))
                    {
                        //login success!
                        foundUser = true;
                        userIndex = users.IndexOf(x);
                        /*LoggedInCustomer = new Customer(userName, pw, 
                            x.getChecking(), x.getSavings());*/
                    }
                       
                }

                

            }
            if (!foundUser)
            {
                Validator.incrementAttempts();
                txtMessage.Text = "INVALID LOGIN. PLEASE RETRY. ATTEMPTS REMAINING: "
                    + (3 - Validator.getAttempts());                
            }
            else
            {
                if (txtPassword.Text.Equals("bye"))
                    System.Environment.Exit(0);


                Validator.clearAttempts(); // clear old bad attempts


                if ((txtUserID.Text).Equals("admin",StringComparison.OrdinalIgnoreCase) &&
                    (txtPassword.Text).Equals("0000"))
                {
                    lockedOut = false;
                    txtMessage.Text = "Admin has unlocked the machine.";
                    txtUserID.Text = "";
                    txtPassword.Text = "";
                    Validator.clearAttempts();
                    return;
                }

                
                //txtMessage.Text = "Congratulations, great success!";
                //Customer(string userID, string password, string cAcctNum, 
                //decimal cAcctBal, string sAcctNum, decimal sAcctBal)

                form2 = new Form2();
                Form7.form1 = this;
                this.Hide();
                txtUserID.Text = ""; // clear inputs for next time
                txtPassword.Text = ""; // clear inputs
                //btClear_Click(sender, e); // save this for later
                form2.Show();
                form2.Focus();
                 
            }


            if (!Validator.canLogin())
            {
                if (!lockedOut || 
                    !((txtUserID.Text).Equals("admin", StringComparison.OrdinalIgnoreCase)))
                {
                    lockedOut = true;
                    txtMessage.Text = Validator.loginBlocked;
                    btClear.Hide();
                    btLogin.Hide();
                    txtUserID.Focus();
                }
            }

        }

    }
}
