using System;
using System.Collections.Generic;
using System.Linq;
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


    }

}
