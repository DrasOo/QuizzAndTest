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
        public MySqlTransaction MySqlCo { get; internal set; }

        private string serveurBDD;    
        private string nomBDD;   
        private string loginBDD;         
        private string mdpBDD;

        public Connection()
        {
            serveurBDD = "localhost";
            nomBDD = "bdd_quizzandtest";
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
