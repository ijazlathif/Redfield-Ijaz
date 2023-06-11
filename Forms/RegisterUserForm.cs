using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1.Forms
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }
        Classes.UserClass userregister = new Classes.UserClass();
        private void RegisterUserForm_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void ADDUSER_Click(object sender, EventArgs e)
        {
            string UserName = AddUserTB.Text;
            string Password = AddPasswordTB.Text;
            ApproveTB.Text = "0";
            int ApproveUser = Convert.ToInt32(ApproveTB.Text);
            if (UserName != "" && Password !="")
            {
               if (userregister.insertData(UserName, Password, ApproveUser))
                    {
                        MessageBox.Show("User Added Successfully", "ADD User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("User Not Added Succesfully");
                    }

            }
            else
            {

                MessageBox.Show("Error : Please enter missing credentials");
            }

        }

        private void EDITUSER_Click(object sender, EventArgs e)
        {
            try
            {
                int UserID = Convert.ToInt32(UIDTB.Text);
                string UserName = AddUserTB.Text;
                string Password = AddPasswordTB.Text;
                int ApproveUser = Convert.ToInt32(ApproveTB.Text);
                if (UserName != "" && Password != "" && UserID != 0 )
                {
                        if (userregister.UpdateData(UserID, UserName, Password, ApproveUser))
                        {
                        MessageBox.Show("User Updated Successfully", "ADD User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        }
                          else
                         {
                        MessageBox.Show("User Not Updated Succesfully");
                         } 
                }
               
                else
                {

                    MessageBox.Show("Please enter missing credentials");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void DELETEUSER_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(UIDTB.Text);

            if (userregister.DeleteData(UserID))
            {
                MessageBox.Show("User Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                UIDTB.Text = "";
                AddUserTB.Text = "";
                AddPasswordTB.Text = "";
                ApproveTB.Text = "";
            }
            else
            {
                MessageBox.Show("User Not Deleted Succesfully");
            }
        }

        private void USERSLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void USERSLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public void LoadData()
        {
            UsersGV.DataSource = userregister.getAllCategories().DefaultView;
            //UsersGV.CellStyle.textcolor = Color.Orange;
            UsersGV.Columns[0].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[1].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[2].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[3].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[4].HeaderCell.Style.BackColor = Color.Orange;
            labelCount.Text = UsersGV.Rows.Count - 1  +"count";


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = UsersGV.Rows[ind];
            UIDTB.Text = selectedRows.Cells[0].Value.ToString();
            AddUserTB.Text = selectedRows.Cells[1].Value.ToString();
            AddPasswordTB.Text = selectedRows.Cells[2].Value.ToString();
            ApproveTB.Text = selectedRows.Cells[3].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelCount_Click(object sender, EventArgs e)
        {
         // int var   = UsersGV.DisplayedRowCount();
           
        }
    }
}
