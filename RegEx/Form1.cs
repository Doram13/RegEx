using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //the following conditions are for the Invalid input! 
            if (NameAlphabeticCheck())
            { 
                MessageBox.Show("The name is invalid! Only alphabetical characters are allowed.");
                return;
            }
            if (PhoneDigitalCheck())
            { 
                MessageBox.Show("The phone number is invalid! Only numbers are allowed.");
                return;
            }
            if (EmailCheck())
            {XmlReadMode
                MessageBox.Show("The email adress is invalid! Only usual adresses like 'some1thing@someserver.something' are allowed.");
                return;
            }
            MessageBox.Show("Congrats, you input is valid!");
        }

        private bool NameAlphabeticCheck()
        {
            return !Regex.IsMatch(txtName.Text, @"^([A-Za-z]+\s*)+$");
        }

        private bool PhoneDigitalCheck()
        {
            return !Regex.IsMatch(txtPhone.Text, @"^[0-9]+$");
        }

        private bool EmailCheck()
        {
            return !Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
        }
    }
}
