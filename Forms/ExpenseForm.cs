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
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }
        Classes.ProfitClass expenses = new Classes.ProfitClass();
        private void ADD_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(ExpenseAmountTB.Text);
            string Description = textBox1.Text;
            int SubCategory = Convert.ToInt32(SubCategoryCB.SelectedValue.ToString());
            int Category = Convert.ToInt32(CategoryTB.SelectedValue.ToString());
            //string Category = CategoryCB.Text;
            if (Amount == 0)
            {
                MessageBox.Show("Enter Amount ");
            }
            else
            {
                if (expenses.insertData(Amount, Description, Category, SubCategory))
                {
                    MessageBox.Show(" Expenses Added Successfully");
                    LoadData();
                }
                else
                {
                    MessageBox.Show(" Expenses Not Added");
                }

            }

        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(ExpenseAmountTB.Text);
            int Expense = Convert.ToInt32(ExpenseID.Text);
            string Description = textBox1.Text;
            
            //string Category = CategoryCB.Text;
            if (Amount == 0)
            {
                MessageBox.Show("Enter Amount ");
            }
            else
            {
                if (expenses.UpdateData(Expense,Amount, Description))
                {
                    MessageBox.Show(" Expenses Updated Successfully");
                    LoadData();
                }
                else
                {
                    MessageBox.Show(" Expenses Not Updated");
                }

            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            int Expense = Convert.ToInt32(ExpenseID.Text);

            //string Category = CategoryCB.Text;
            if (Expense == 0)
            {
                MessageBox.Show("Incorrect Expense ID ");
            }
            else
            {
                if (expenses.DeleteData(Expense))
                {
                    MessageBox.Show(" Expenses Deleted Successfully");
                    LoadData();
                }
                else
                {
                    MessageBox.Show(" Expenses Not Deleted");
                }

            }

        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            
            Classes.SubCategoryClass SubCategory = new Classes.SubCategoryClass();
            Classes.CategoryClass Category = new Classes.CategoryClass();
            SubCategoryCB.DataSource = SubCategory.getAllCategories();
            SubCategoryCB.DisplayMember = "SubCategory";
            SubCategoryCB.ValueMember = "SubCatID"; 
            CategoryTB.DataSource = Category.getAllCategories();
            CategoryTB.DisplayMember = "Categories";
             CategoryTB.ValueMember = "CatID";
            LoadData();


        }

        
        void LoadData()
        {
            UsersGV.DataSource = expenses.getAllCategories().DefaultView;
            //UsersGV.CellStyle.textcolor = Color.Orange;
            UsersGV.Columns[0].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[1].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[2].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[3].HeaderCell.Style.BackColor = Color.Orange;
            UsersGV.Columns[4].HeaderCell.Style.BackColor = Color.Orange;
            Count.Text = UsersGV.Rows.Count - 1 + "count";
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = UsersGV.Rows[ind];
            ExpenseID.Text = selectedRows.Cells[0].Value.ToString();
            ExpenseAmountTB.Text = selectedRows.Cells[1].Value.ToString();
            textBox1.Text = selectedRows.Cells[2].Value.ToString();
            SubCategoryCB.Text = selectedRows.Cells[3].Value.ToString();
            CategoryTB.Text = selectedRows.Cells[4].Value.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
