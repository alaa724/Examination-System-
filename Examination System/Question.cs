using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Question 
    {
        
        #region Property

        public abstract string? Header { get; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[]? AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers UserAnswer { get; set; }

        #endregion


        #region Constractor

        protected Question()
        {
            
            AnswerList = new Answers[0];
            RightAnswer = new Answers();
            UserAnswer = new Answers();
        }

        #endregion

        #region Methods

        public abstract void AddQuestion();

        public override string ToString()
        {
            return $"{Header} \t {Body} \t {Mark}";
        }

        #endregion





    }
}
