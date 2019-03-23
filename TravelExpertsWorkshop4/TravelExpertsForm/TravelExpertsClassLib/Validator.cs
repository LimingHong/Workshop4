using System;
using System.Windows.Forms;

namespace TravelExpertsClassLib
{
    /// <summary>
    /// Provides static methods for validating data.
    /// </summary>
    public static class Validator
    {


        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsPresentCombo(ComboBox textBox, string name)
        {
            if (textBox.DisplayMember == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentRichTB(RichTextBox richtextBox, string name)
        {
            if (richtextBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                richtextBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentDateTimePicker(DateTimePicker dateTimePicker, string name)
        {
            if (dateTimePicker.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                dateTimePicker.Focus();
                return false;
            }
            return true;
        }

        public static bool IsCorrectLength(TextBox textBox, string name, int maxLen)
        {
            if ((textBox.Text).Length > maxLen)
            {
                MessageBox.Show(name + " can be at most " + maxLen.ToString() + " long", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsNonNegativeDecimal(TextBox textBox, string name)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(name + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsNonNegativeInt(TextBox textBox, string name)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(name + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}