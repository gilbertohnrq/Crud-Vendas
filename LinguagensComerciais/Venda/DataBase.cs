using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Venda
{
   public class DataBase
    {
        
        public DataBase()
        {
            openConnection();

        }
        
        SqlConnection con { get; set; }

        string connectionString = "Data Source=localhost;Initial Catalog=TrabalhoLC;Integrated Security=True"; //editar em outros pcs

        public void openConnection() {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open() ;

            }
            catch (Exception e)
            {
                con = null;    
                Console.WriteLine(e.Message);
            }

        }
        public void closeConnection()
        {
            con.Close();
        }
        
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
