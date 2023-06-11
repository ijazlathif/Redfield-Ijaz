using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class CategoryClass
    {
        DBFunctions Func = new DBFunctions();
        //insert  category
        public Boolean insertCategories(string Categories)
        {
            //INSERT INTO `users`(`UserID`, `UserName`, `Password`) VALUES('[value-1]', '[value-2]', '[value-3]')
            MySqlCommand command = new MySqlCommand("INSERT INTO `category`(`Categories`) VALUES (@cat)");
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = Categories;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Update 
        public Boolean UpdateData(int CatID, string Categories)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `category` SET `Categories`= @cat WHERE `CatID`= @Catid");
            command.Parameters.Add("@Catid", MySqlDbType.Int32).Value = CatID;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = Categories;
            return Func.ExecuteQueryDataToDB(command);
        }

        //category Delete 
        public Boolean DeleteData(int CatID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `category` WHERE `CatID`= @Catid");
            command.Parameters.Add("@Catid", MySqlDbType.Int32).Value = CatID;
            return Func.ExecuteQueryDataToDB(command);
        }

        // get all Categories
        public DataTable getAllCategories()
        {
            MySqlCommand command = new MySqlCommand("Select * From  category");
            return Func.getData(command);
        }

    }
}

