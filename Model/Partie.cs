using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Partie(int score, int difficulteMode, int nbQuestion, List<Question> questionList, int bonneReponse, int numQuestion)
        {
            this.score = score;
            this.difficulteMode = difficulteMode;
            this.nbQuestion = nbQuestion;
            this.questionList = questionList;
            BonneReponse = bonneReponse;
            this.numQuestion = numQuestion;
        }
    }
}
