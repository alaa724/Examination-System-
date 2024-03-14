using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Subject 
    {

        #region Property
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam? ExamSubj { get; set; }
        #endregion


        #region Constractor
        public Subject(int id, string? name)
        {
            Id = id;
            Name = name;
        }
        #endregion


        #region Mehtods

        public void CreateExam()
        {
            int time, examType, numOfQuestions;
            do
            {
                Console.WriteLine("Enter Type Of Exam >> ( 1 for 'PracticalExam' || 2 for 'FinalExam')");

            } while (! int.TryParse(Console.ReadLine() , out examType) && examType < 1 || examType > 2);

            do
            {
                Console.WriteLine("Enter The Time Of Exam");

            } while (!int.TryParse(Console.ReadLine(), out time));
            //Exam.Time = time;

            do
            {
                Console.WriteLine("Enter Number Of Questions");

            } while (!int.TryParse(Console.ReadLine(), out numOfQuestions) && numOfQuestions < 1); 

            if(examType == 1)
                ExamSubj = new PracticalExam(time, numOfQuestions);
            else if(examType == 2)
                ExamSubj = new FinalExam(time, numOfQuestions);

            Console.Clear();

            ExamSubj?.CreateQuestions();


        }




        #endregion


    }
}
