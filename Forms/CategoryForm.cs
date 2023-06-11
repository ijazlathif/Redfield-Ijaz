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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        Classes.CategoryClass Categories1 = new Classes.CategoryClass();

        private void CategorySLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow DR = Categories1.getAllCategories().Rows[CategorySLB.SelectedIndex];
            CatIDTB.Text = DR.ItemArray[0].ToString();
            CatTB.Text = DR.ItemArray[1].ToString();
            
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void ADDCategory_Click(object sender, EventArgs e)
        {
            String Categories = CatTB.Text;
            if (Categories != "")
            {
                if (Categories1.insertCategories(Categories))
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

        private void EDITCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int CatID = Convert.ToInt32(CatIDTB.Text);
                String Categories = CatTB.Text;
                if (Categories != "" & CatID != 0)
                {
                    if (Categories1.UpdateData(CatID, Categories))
                    {
                        MessageBox.Show("Categories Updated Successfully", "ADD Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Categories Not Updated Succesfully");
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

        private void DELETECategory_Click(object sender, EventArgs e)
        {
            if (CatIDTB.Text == "")
            {
                MessageBox.Show("Category ID should not be empty");
            }
            else
            {
                int CatID = Convert.ToInt32(CatIDTB.Text);



                if (Categories1.DeleteData(CatID))
                {
                    MessageBox.Show("Category Deleted Successfully", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    CatIDTB.Text = "";
                    CatTB.Text = "";

                }
                else
                {
                    MessageBox.Show("Category Not Deleted Succesfully");
                }
            }
        }
        public void LoadData()
        {

            CategorySLB.DataSource = Categories1.getAllCategories();
            CategorySLB.ValueMember = "CatID";
            CategorySLB.DisplayMember = "Categories";
            //USERSLB.DisplayMember = "Password";

            // CategorySLB.SelectedItem = null;
        }

        private void CatIDTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
