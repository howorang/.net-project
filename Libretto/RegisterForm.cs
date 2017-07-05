using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libretto.Model.Entity;
using Libretto.Model;
using System.Security.Cryptography;

namespace Libretto
{
    public partial class RegisterForm : Form
    {

        private LibrettoContext ctx = DbManager.Instance.Context;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                User newUser = new User();
                newUser.Username = loginTextBox.Text;
                newUser.Password = AuthManager.sha256_hash(passwordTextBox.Text);
                
                newUser.UserRole = GetUserRole();
                ctx.Users.Add(newUser);
                ctx.SaveChanges();
                MessageBox.Show("Zarejestrowano.");
                Close();
            }
        }

        private Role GetUserRole()
        {
            return ctx.Roles.Where(r => r.Name == "USER").First();
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(loginTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(loginTextBox, "Wpisz poprawny login.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTextBox, "Wpisz poprawne hasło.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void repeatPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(passwordTextBox.Text != repeatPasswordTextBox.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(repeatPasswordTextBox, "Hasła nie zgadzją się.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
