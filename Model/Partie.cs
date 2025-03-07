using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest.Model
{
    public class Partie
    {
        public int score;
        public int difficulteMode;
        public int nbQuestion;
        public List<Question> questionList;
        public int BonneReponse;
        public int numQuestion;
        public int reponseValidQuestion;
        public string difficulte;
        public string nomJoueur;
        public string prenomJoueur;
        public int dureePartie;
        public int dureeTQuestion;
        public Timer timer;
        private SousFormulaire SF;



        public Partie(List<Question> listevouluQuestion)
        {
            score = 0;
            difficulte = "";
            difficulteMode=0;
            nbQuestion = 0;
           
            numQuestion = 0;
            questionList = listevouluQuestion;
            nbQuestion = listevouluQuestion.Count;
            
        }
        public Partie(List<Question> ListeQuestions, string nomJ, string prenomJ, string difficulteJ)
        {
            score = 0;
            difficulte = difficulteJ;
            nbQuestion = 0;
            questionList = ListeQuestions;
            nbQuestion = questionList.Count;
            nomJoueur = nomJ;
            prenomJoueur = prenomJ;
        }

        private void changerImg(PictureBox picbox_img, bool BonneReponse, bool raz)
        {
            if (!raz)
            {
                if (BonneReponse)
                {
                    picbox_img.Image = Properties.Resources.vrai;
                }
                else
                {
                    picbox_img.Image = Properties.Resources.faux;
                }
            }
            else
            {
                picbox_img.Image = Properties.Resources.Interrogation;
            }
        }
        private void calculerScore(bool BonneReponse)

        {
            if (BonneReponse)
            {
                score = +1;
            }
            
        }
        public void validerReponse(int reponse, PictureBox picbox_img)
        {
            if (reponse == BonneReponse)
            {
                calculerScore(true); // Il faut créer cette méthode privé qui ajoute +1 au score à chaque bonne réponse *FAIT
                changerImg(picbox_img, true, false);
            }
            else
            {
                calculerScore(false);
                changerImg(picbox_img,false, false);
            }
        }
        private void aleatoireReponse(TextBox txtbox_question, GroupBox grpbox_rep)
        {
            int bonneReponse = questionList[numQuestion].reponse;
            txtbox_question.Text = questionList[numQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                //switch
                switch (random)
                {
                    case 1:
                        reponse = questionList[numQuestion].proposition1;
                        break;
                    case 2:
                        reponse = questionList[numQuestion].proposition2;
                        break;
                    case 3:
                        reponse = questionList[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = questionList[numQuestion].proposition4;
                        break;
                    case 5:
                        reponse = questionList[numQuestion].proposition5;
                        break;
                }

                getCheckBox(i, grpbox_rep).Text = reponse;
                if (bonneReponse == random)
                {
                    BonneReponse = i;
                }
            }
        }
        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "chkbox_rep" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }


        public void changerQuestion(TextBox txtbox_question, CheckBox chkbox_rep1, CheckBox chkbox_rep2, CheckBox chkbox_rep3, CheckBox chkbox_rep4, CheckBox chkbox_rep5, Form Form1, GroupBox grpbox_rep, PictureBox picbox_img, Panel pnl_principal)
        {
            if (numQuestion != nbQuestion)
    {
                aleatoireReponse(txtbox_question, grpbox_rep);
                chkbox_rep1.Checked = false;
                chkbox_rep2.Checked = false;
                chkbox_rep3.Checked = false;
                chkbox_rep4.Checked = false;
                chkbox_rep5.Checked = false;
                // On décoche les 5 checkbox

            }
            else
            {
                finDePartie(txtbox_question, chkbox_rep1, chkbox_rep2, chkbox_rep3, chkbox_rep4, chkbox_rep5, Form1, grpbox_rep, picbox_img , pnl_principal);
            }
        }
        
        public void finDePartie(TextBox txtbox_question, CheckBox chkbox_rep1, CheckBox chkbox_rep2, CheckBox chkbox_rep3, CheckBox chkbox_rep4, CheckBox chkbox_rep5, Form Form1, GroupBox grpbox_rep, PictureBox picbox_img,Panel pnl_principal)
        {
            DialogResult msg;
            timer.Stop();
            SF = new SousFormulaire(pnl_principal);
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n vous avez fini la partie en " + dureePartie + " secondes.\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numQuestion = 0;
                dureePartie = 0;
                changerQuestion(txtbox_question, chkbox_rep1, chkbox_rep2, chkbox_rep3, chkbox_rep4, chkbox_rep5, Form1, grpbox_rep, picbox_img, pnl_principal);
                changerImg(picbox_img, true, true);
                timer.Start();
            }
            else
            {
                SF.openChildForm(new Form1());
                Form1.Hide();


            }


        }
        public void gestionTimer(TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numQuestion, Panel pnl_principal)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, numQuestion, pnl_principal);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label nQuestion, Panel pnl_principal)
        {
            dureePartie++;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            txt_timer.Text = dureePartie.ToString() + " sec";
            if (dureeTQuestion > 15)
            {
                validerReponse(0, PbImage);
                numQuestion++;
                nQuestion.Text = "Question " +(numQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_principal);
                pb_dureeRepQuestion.Value = 0;
                dureeTQuestion = 0;
            }
        }

    }

}
