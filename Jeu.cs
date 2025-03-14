using QuizzAndTest.Model;
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
    public partial class Jeu : Form
    {
        int reponseQuestion = 0;
        Partie partie;

        private void Init()
        {
            InitializeComponent();
            List<Question> ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));

            partie = new Partie(ListeQuestions);
            partie.changerQuestion(txtbox_question, chkbox_rep1, chkbox_rep2, chkbox_rep3, chkbox_rep4, chkbox_rep5, this, grpbox_rep, picbox_img, null);
            partie.gestionTimer(txtbox_tempstot, prgBar_timer, txtbox_question, chkbox_rep1, chkbox_rep2, chkbox_rep3, chkbox_rep4, chkbox_rep5, this, grpbox_rep, picbox_img, lbl_question, null);

        }


        public Jeu(string nomJ, string PrenomJ, string difficultePartie)
        {
            
            Init();
            partie.nomJoueur = nomJ;
            partie.prenomJoueur = PrenomJ;
            partie.difficulte = difficultePartie;
            txtbox_joueur.Text = nomJ + " " + PrenomJ;
            txtbox_difficulte.Text = difficultePartie;
        }



        private void but_validation_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, picbox_img);
            partie.numQuestion++;
            partie.changerQuestion(txtbox_question, chkbox_rep1, chkbox_rep2, chkbox_rep3, chkbox_rep4, chkbox_rep5, this, grpbox_rep, picbox_img, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).panel_menu);
            lbl_question.Text ="Question " +  (partie.numQuestion + 1).ToString();
            reponseQuestion = 0;

           

        }

        

        private void chkbox_rep1_Click(object sender, EventArgs e)
        {
            //Boucle permettant de décocher toutes les cases à cocher du formulaire
            foreach (var box in grpbox_rep.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }

            
            ((CheckBox)sender).Checked = true;

            reponseQuestion = int.Parse(((CheckBox)sender).Name.Substring(10, 1));
            //Mettre dans une variable la réponse choisis par l’utilisateur
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but_leave_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
