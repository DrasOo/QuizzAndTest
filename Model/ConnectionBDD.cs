using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QuizzAndTest.Model
{
    public class Connection
    {
      
        private MySqlConnection mySqlCo;
        public MySqlConnection MySqlCo { get { return mySqlCo; } set { mySqlCo = value; } }

        private string serveurBDD;    
        private string nomBDD;   
        private string loginBDD;         
        private string mdpBDD;

        public Connection()
        {
            serveurBDD = "localhost";
            nomBDD = "bdd_quizenzo";
            loginBDD = "root";
            mdpBDD = "";
            initConnexion();
        }
       
        private void initConnexion()
        {
            mySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }


    }



}
