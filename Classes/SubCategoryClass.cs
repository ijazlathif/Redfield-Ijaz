using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;


namespace WindowsFormsApp1.Classes
{
    class SubCategoryClass
    {
        Classes.DBFunctions Func = new Classes.DBFunctions();
        //insert  category
        public Boolean insertSubCategories(string SubCategory,int Category)
        {
            //INSERT INTO `users`(`UserID`, `UserName`, `Password`) VALUES('[value-1]', '[value-2]', '[value-3]')
            MySqlCommand command = new MySqlCommand("INSERT INTO `subcategory`(`SubCategory`, `CatID`) VALUES (@subcat,@catID)");
            command.Parameters.Add("@subcat", MySqlDbType.VarChar).Value = SubCategory;
            command.Parameters.Add("@catID", MySqlDbType.Int32).Value = Category;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Update 
        public Boolean UpdateData(int SubCatID, string SubCategory)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `subcategory` SET `SubCategory`= @subcat WHERE `SubCatID`= @Catid");
            command.Parameters.Add("@Catid", MySqlDbType.Int32).Value = SubCatID;
            command.Parameters.Add("@subcat", MySqlDbType.VarChar).Value = SubCategory;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Delete 
        public Boolean DeleteData(int SubCatID1)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `subcategory` WHERE `SubCatID`= @SubCatid");
            command.Parameters.Add("@SubCatid", MySqlDbType.Int32).Value = SubCatID1;
            return Func.ExecuteQueryDataToDB(command);
        }

        // get all Categories
        public DataTable getAllCategories()
        {
            MySqlCommand command = new MySqlCommand("Select SubCatID,SubCategory,subcategory.catID From  subcategory INNER JOIN category ON subcategory.catID = category.catID");
            return Func.getData(command);
        }
    }
    
}
