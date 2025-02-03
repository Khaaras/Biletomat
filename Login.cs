using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Test.Models;

namespace Test
{
    public partial class Login : Form
    {
        Users users = new Users();
        DataBaseContext db = new DataBaseContext();
        public static Login instance;
        public int userId;
        public Login()
        {
            InitializeComponent();
            instance = this;
        }

        private void LogIn(string userLogin, string userPassword)
        {
            userLogin = textLogin.Text;
            userPassword = textPassword.Text;
            List<Users> users = db.Users.ToList();

            var u = users.Where(c => c.Login == userLogin).Where(d => d.Password == userPassword).SingleOrDefault();

            if (u != null && u.Login == "Admin")
            {
                                MessageBox.Show("Dzień dobry Adminie");
                this.Hide();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                return;
                
            }
            if(u != null && u.Login != "Admin")
            {
                userId = u.Id;
                MessageBox.Show("Dzień dobry użytkowniku");
                this.Hide();
                UserWindow userWindow = new UserWindow();
                userWindow.Show();
                
                
            }
            else
            {
                MessageBox.Show("Brak użytkownika, albo niepoprawny Login/Hasło");
            }
        }
        

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }

        private void buttonCloseAll_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogIn(textLogin.Text, textPassword.Text);
        }
    }
}
