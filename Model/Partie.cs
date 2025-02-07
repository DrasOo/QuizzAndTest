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

      
        public Partie(List<Question> listevouluQuestion)
        {
            score = 0;
            difficulteMode=0;
            nbQuestion = 0;
           
            numQuestion = 0;
            questionList = listevouluQuestion;
            nbQuestion = listevouluQuestion.Count;
            
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
        }
        private void calculerScore()
        {
            score =+ 1;
        }
        public void validerReponse(int reponse, PictureBox picbox_img)
        {
            if (reponse == BonneReponse)
            {
                calculerScore(); // Il faut créer cette méthode privé qui ajoute +1 au score à chaque bonne réponse *FAIT
                changerImg(picbox_img, true, false);
            }
            else
            {
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
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }


        public void changerQuestion(TextBox txtbox_question, CheckBox chkbox_rep1, CheckBox chkbox_rep2, CheckBox chkbox_rep3, CheckBox chkbox_rep4, CheckBox chkbox_rep5, Form Form1, GroupBox grpbox_rep, PictureBox picbox_img)
        {
            if (numQuestion == nbQuestion)
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
                //appel de la méthode de fin de partie qui sera réalisé plus tard
            }
        }



    }

}
