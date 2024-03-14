using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Answers
    {
        #region Property

        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        #endregion

        #region Constractor
        public Answers()
        {

        }
        public Answers(int _AnswerId, string? _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        }

        #endregion

        #region Methode

        public override string ToString()
        {
            return $"Id ={AnswerId} ::: Text = {AnswerText}";
        }

        #endregion


    }
}
