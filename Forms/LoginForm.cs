using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            string Username = UserNameTB.Text;
            string Password = passwordTB.Text;
            Classes.DBFunctions func = new Classes.DBFunctions();
            if (UserNameTB.Text == "")
            {
                MessageBox.Show("Pls Enter Username");
                ValidationLB.Text = "Pls Enter Username";
            }
            if (passwordTB.Text == "")
            {
                ValidationLB.Text = "Pls Enter password";
                MessageBox.Show("Pls Enter password");
            }
            if (UserNameTB.Text != "" && passwordTB.Text != "")
            {
                
                //Creating SQL Command to pass value
                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE UserName =@username AND Password =@password AND ApproveUser =1 ");
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
                DataTable table = func.getData(command);
                //After getting the Match count
                if(table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Not Success : UserName or Password is wrong");
                }
                

            }
        }

        private void ValidationLB_Click(object sender, EventArgs e)
        {

        }
    }
}
