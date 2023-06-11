using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class DB_Connection
    {
        //String Striop = "Server=localhost;Database=RealEstateC#Project;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=RealEstateC#Project;Uid=root;Pwd=;");
        //get connection status
        public MySqlConnection getConnection
        {
            get
            {
                return connection;
            }
                
        }
        //open connection
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //Close connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
    }
}
