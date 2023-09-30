using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public static class Validator
    {
        private static string title = "Entry Error";
        private static int numAttempts = 0;
        public static string loginBlocked = "PLEASE SEE A BANK OFFICER-- " +
            "NO FURTHER LOGIN ATTEMPTS ALLOWED";

        public static string Title
        {
            get {return title; }
            set {title = value;}
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsAlphanumeric(TextBox textBox)
        {
            foreach (char x in textBox.Text)
                if (!char.IsLetterOrDigit(x))
                {
                    MessageBox.Show(textBox.Tag + " must be alphanumeric.", Title);
                    textBox.Focus();
                    return false;
                }
            return true;
        }

        public static bool IsNumeric(TextBox textBox)
        {
            decimal x = 0m;
            if (Decimal.TryParse(textBox.Text, out x))
                return true;
            else
            {
                MessageBox.Show(textBox.Tag + " must be a numeric value.", Title);
                textBox.Focus();
                return false;
            }

        }

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
                return true;
            else {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        // good for currency vv
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        public static bool IsCorrectNumDigits(TextBox textBox, int required = 8)
        {
            int numDigits = textBox.Text.Length;
            if (numDigits != required)
            {
                MessageBox.Show(textBox.Tag + " must be " + required + " digits.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        //private static int numAttempts = 0;

        public static void incrementAttempts()
        {
            numAttempts++;
        }

        public static void clearAttempts()
        {
            numAttempts = 0;
        }
        
        public static int getAttempts()
        {
            return numAttempts;
        }

        public static bool canLogin()
        {
            return (numAttempts < 3);
        }


        public static bool IsSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show(comboBox.Tag + " is a required field.", Title);
                comboBox.Focus();
                return false;
            }
            return true;
        }


        public static bool IsDifferentAccount(ComboBox cb1, ComboBox cb2)
        {
            
            if (cb1.SelectedIndex == cb2.SelectedIndex)
            {
                MessageBox.Show("You can only transfer funds between two DIFFERENT accounts!", Title);
                cb1.Focus();
                return false;
            }
            return true;
        }


    }
}
