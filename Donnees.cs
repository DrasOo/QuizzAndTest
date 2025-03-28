using QuizzAndTest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public partial class Donnees : Form
    {
        QuestionBDD dt_question;
        DataView dv;
        Difficulte dt_difficulte;
        public Donnees()
        {
            InitializeComponent();
            dt_question = new QuestionBDD();
            dv = new DataView(dt_question.GetListeQuestion());
            //Difficulté
            dt_difficulte = new Difficulte();
            combo_difficulte.DataSource = dt_difficulte.GetListeDifficulte();
            combo_difficulte.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            combo_difficulte.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne
            //Recherche
            
            //DataGridview
            datagv_tab.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            datagv_tab.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            datagv_tab.Columns["QUESTION"].Width = 634;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
        }

        private void but_leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
