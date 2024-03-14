using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam 
    {
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public Question[]? ArrayOfQuestion { get; set; }
        public Subject? SubjExam { get; set; }

        public Exam(int _Time , int _NumOfQuestions)
        {
            Time = _Time;
            NumOfQuestions = _NumOfQuestions;
        }

        public abstract void ShowExam();

        public abstract void CreateQuestions();


    }
}
