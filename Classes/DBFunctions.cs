using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class DBFunctions
    {

        DB_Connection connection = new DB_Connection();
        //Insert
        public Boolean ExecuteQueryDataToDB(MySqlCommand command)
        {
            command.Connection =connection.getConnection;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
           
        }


        //Update

        //Delete


        //get Data
        public  DataTable getData(MySqlCommand command)
        {
            //MySqlCommand command = new MySqlCommand(query, connection.getConnection);
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }




    }
}
