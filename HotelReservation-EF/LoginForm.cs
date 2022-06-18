using MetroFramework.Forms;
using System;
using HotelReservation_EF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation_EF
{
    
    public partial class LoginForm : MetroForm
    {
        Form1 RsrvForm = new Form1();
        LoginContext Context;
        public LoginForm()
        {
            InitializeComponent();
            Context = new LoginContext();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Context.Frontend.Load();
            Context.Kitchen.Load();
            this.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var usersFront = Context.Frontend.Local;
            var usersKitchen = Context.Kitchen.Local;

            if(txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var userExist = usersFront.FirstOrDefault(a => a.UserName.Equals(txtUsername.Text));
                if(userExist != null)
                {
                    if (userExist.PassWord.Equals(txtPassword.Text)) {
                        MessageBox.Show("Welcome: " + userExist.UserName);
                        RsrvForm.Show();
                        this.Hide();
                    }
                        
                    else
                        MessageBox.Show("Incorrect Password!");
                }
                else
                {
                    MessageBox.Show("User Not Found!");
                }
            }
            else { MessageBox.Show("Please Enter Username And Password"); }
        }
    }
}
