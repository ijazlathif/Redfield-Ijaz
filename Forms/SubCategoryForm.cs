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
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
        }
        Classes.SubCategoryClass SubCategory2 = new Classes.SubCategoryClass();

        private void ADDBT_Click(object sender, EventArgs e)
        {
            string SubCategor = SubCatTB.Text;
            int Categorie = Convert.ToInt32(CategoryCB.SelectedValue.ToString());
            //string Category = CategoryCB.Text;
            if ( SubCatTB.Text == "" || CategoryCB.Text == "")
            {
                MessageBox.Show("Enter SubCategory");
            }
            else
            {
                if (SubCategory2.insertSubCategories(SubCategor, Categorie))
                {
                    MessageBox.Show(" SubCategory Added Successfully");
                    LoadData();
                }

            }

        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            string SubCategor = SubCatTB.Text;
            int CategorieID = Convert.ToInt32(SubCatIDTB.Text);
            //string Category = CategoryCB.Text;
            if( SubCatIDTB.Text == "")
            {
               MessageBox.Show("Don't change SubCategory ID");

            }
            if (SubCatTB.Text == "" )
            {
                MessageBox.Show("Enter SubCategory");
                
            }
            else
            {
                if (SubCategory2.UpdateData(CategorieID,SubCategor))
                {
                    LoadData();
                    MessageBox.Show(" SubCategory Updded Successfully");
                }

            }

        }

        private void DELETEBT_Click(object sender, EventArgs e)
        {
         if (SubCatIDTB.Text == "")
            {
                MessageBox.Show("Category ID should not be empty");
            }
            else
            {
                int CatID = Convert.ToInt32(SubCatIDTB.Text);



                if (SubCategory2.DeleteData(CatID))
                {
                    MessageBox.Show("SubCategory Deleted Successfully", "Delete SubCategory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    SubCatIDTB.Text = "";
                    SubCatTB.Text = "";

                }
                else
                {
                    MessageBox.Show("SubCategory Not Deleted Succesfully");
                }
            }

        }

        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            Classes.CategoryClass Category = new Classes.CategoryClass();

            CategoryCB.DataSource = Category.getAllCategories();
            CategoryCB.DisplayMember = "Categories";
            CategoryCB.ValueMember = "CatID";

            LoadData();
        }

        private void SUbCatLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow DR = SubCategory2.getAllCategories().Rows[SUbCatLB.SelectedIndex];
            SubCatIDTB.Text = DR.ItemArray[0].ToString();
            SubCatTB.Text = DR.ItemArray[1].ToString();
            CategoryCB.Text = DR.ItemArray[2].ToString();
        }
        public void LoadData()
        {
            SUbCatLB.DataSource = SubCategory2.getAllCategories();
            SUbCatLB.ValueMember = "SubCatID";
            SUbCatLB.DisplayMember = "SubCategory";
        }
    }
}
