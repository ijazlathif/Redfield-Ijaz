using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class UserClass
    {
       DBFunctions Func = new DBFunctions();
        //insert User
        public Boolean insertData(string UserName ,string Password, int approveuser)
        {
            //INSERT INTO `users`(`UserID`, `UserName`, `Password`) VALUES('[value-1]', '[value-2]', '[value-3]')
            MySqlCommand command1 = new MySqlCommand("INSERT INTO `users`(`UserName`, `Password`,`ApproveUser`) VALUES (@un,@pass,@approveuser)");
            command1.Parameters.Add("@un",MySqlDbType.VarChar).Value= UserName;
            command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
            command1.Parameters.Add("@approveuser", MySqlDbType.Int32).Value = approveuser;
            
            return Func.ExecuteQueryDataToDB(command1);
        }

        //UserUpdate 
        public Boolean UpdateData(int UserID ,string UserName, string Password,int Approveuser)
        {
            //UPDATE `users` SET `UserID`= '[value-1]',`UserName`= '[value-2]',`Password`= '[value-3]',`TimeStamp`= '[value-4]',`ApproveUser`= '[value-5]' WHERE 1
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `UserName`= @un,`Password`= @pass,`ApproveUser`= @approv WHERE `UserID`= @id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = UserID;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@approv", MySqlDbType.Int32).Value = Approveuser;
            return Func.ExecuteQueryDataToDB(command);
        }

        //UserUpdate 
        public Boolean DeleteData(int UserID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `UserID`= @id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = UserID;
            return Func.ExecuteQueryDataToDB(command);
        }

        // get all Categories
        public DataTable getAllCategories()
        {
            MySqlCommand command = new MySqlCommand("Select UserID,UserName,Password,ApproveUser,TimeStamp From  users");
            return Func.getData(command);
        }

    }
}
