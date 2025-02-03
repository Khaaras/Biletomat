using System;
using System.Windows.Forms;
using Test.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public partial class CreateUser : Form
    {
        Users users = new Users();
        DataBaseContext db = new DataBaseContext();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void buttonCreateConfirm_Click(object sender, EventArgs e)
        {
           
            users.FirstName = textCreateFirstName.Text;
            users.LastName = textCreateLastName.Text;
            users.Login = textCreateLogin.Text;
            users.Password = textCreatePassword.Text;
            users.FullName = textCreateFirstName.Text + " " + textCreateLastName.Text;

            db.Users.Add(users);
            int a = db.SaveChanges();
            if (a > 0)
            {
                MessageBox.Show("Udało się");
            }
            else
            {
                MessageBox.Show("Nie udało się :(:(");
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
