using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.Classes
{
    class ProfitClass
    {
        Classes.DBFunctions Func = new Classes.DBFunctions();
        //insert  category
       
        public Boolean insertData(int Amount ,string Description ,int SubCategory, int Category)
        {
            //INSERT INTO `users`(`UserID`, `UserName`, `Password`) VALUES('[value-1]', '[value-2]', '[value-3]')
           
            MySqlCommand command = new MySqlCommand(" INSERT INTO `expenses`(`EXpenseAmount`, `Description`, `CatID`, `SubCatID`) VALUES(@expense, @description, @catID, @subcatID)");
            command.Parameters.Add("@expense", MySqlDbType.Int32).Value = Amount;
            command.Parameters.Add("@catID", MySqlDbType.Int32).Value = Category;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;
            command.Parameters.Add("@subcatID", MySqlDbType.Int32).Value = SubCategory;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Update 
        public Boolean UpdateData(int Expense, int Amount, string Description)
        {
           
            MySqlCommand command = new MySqlCommand(" UPDATE `expenses` SET `EXpenseAmount`= @exp,`Description`= @des WHERE `ID`=@id ");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Expense;
            command.Parameters.Add("@exp", MySqlDbType.Int32).Value = Amount;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = Description;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Delete 
        public Boolean DeleteData(int Expense)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `expenses` WHERE `ID`= @id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Expense;
            return Func.ExecuteQueryDataToDB(command);
        }

        // get all Categories
        public DataTable getAllCategories()
        {
            MySqlCommand command = new MySqlCommand("Select * From expenses");
            return Func.getData(command);
        }
    }
}
