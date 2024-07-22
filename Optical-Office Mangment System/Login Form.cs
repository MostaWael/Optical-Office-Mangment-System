using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optical_Office_Mangment_System
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                this.Hide(); // Hide the login form instead of closing it
                mainForm = new MainForm();
                mainForm.FormClosed += MainForm_FormClosed; // Subscribe to the FormClosed event
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when the main form is closed
        }

    }
}
