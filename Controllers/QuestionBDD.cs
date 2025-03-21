using MySqlConnector;
using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest.Controllers
{
    public class QuestionBDD
    {
        DataTable dt;
        Connection conn;
        public DataTable GetListeQuestion()
        {
            dt = new DataTable();
            conn = new Connection();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION AS 'QUESTION', d.LABELDIFFICULTE AS 'DIFFICULTE' FROM QUESTION q INNER JOIN DIFFICULTE d ON q.IDDIFFICULTE = d.IDDIFFICULTE", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;

            return dt;

        }

    }
}
