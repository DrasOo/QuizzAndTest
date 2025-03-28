using MySqlConnector;
using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizzAndTest.Controllers
{
    public class Difficulte
    {
        Connection conn;
        DataTable dt;        

        //"SELECT Level FROM Difficulte";
        public DataTable GetListeDifficulte()
        {
            dt = new DataTable();
            conn = new Connection();
            
            using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE,LABELDIFFICULTE FROM difficulte;", conn.MySqlCo))
            {
                conn.MySqlCo.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            DataRow workRow = dt.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dt.Rows.InsertAt(workRow, 0);
            return dt;
        }
    }
}
