using Libretto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libretto
{
    public partial class LoginForm : Form
    {
        private LibrettoContext ctx = DbManager.Instance.Context;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string passwordhash = AuthManager.sha256_hash(passwordTextBox.Text);
                var userLoggedIn = from user in ctx.Users
                                   where user.Username == loginTextBox.Text
                                   where user.Password == passwordhash
                                   select user;
                if (userLoggedIn.Count() != 0)
                {
                    AuthManager.Instance.CurrentUser = userLoggedIn.First();
                    Hide();
                    MainForm form = new MainForm();
                    form.FormClosed += (s, args) => Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Błąd", "");
                }
            }
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(loginTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(loginTextBox, "Wpisz login.");
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
                errorProvider1.SetError(passwordTextBox, "Wpisz hasło.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm newForm = new RegisterForm();
            newForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
