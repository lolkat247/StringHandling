using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            // vars
            string email, username, domain;

            // var in
            try
            {
                email = tbEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return;
            }

            // validate data
            if (!email.Contains("@"))
            {
                MessageBox.Show("Non-email input", "Format Error");
                return;
            }

            // format data
            username = email.Split('@')[0];
            domain = email.Split('@')[1];

            // display data
            MessageBox.Show(
                // body
                "User name: " + username + '\n' +
                "Domain name: " + domain,

                // title
                "Parsed String"
                );
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            // vars 
            string city, state, zip;
            
            // get data
            try
            {
                city = tbCity.Text;
                state = tbState.Text;
                zip = tbZipCode.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return;
            }

            // NO validation required

            // format data
            state = state.ToUpper();

            // display data
            MessageBox.Show(
                // body
                "City, State, Zip: " + city + ", " + state + ' ' + zip,

                // title
                "Formatted String"
                );

        }
    }
}
