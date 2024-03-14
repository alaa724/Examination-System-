using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumOfQuestions) : base(_Time, _NumOfQuestions)
        {

        }

        public override void CreateQuestions()
        {
            ArrayOfQuestion = new Question[NumOfQuestions];
            int Choice;
            for(int i =0; i < NumOfQuestions; i++)
            {
                do
                {
                    Console.WriteLine("Enter Type Of Question ( 1 >> MCQ | 2 >> True\\False )");

                } while (! int.TryParse(Console.ReadLine(),out Choice) && Choice < 1 || Choice > 2);
                if(Choice == 1)
                {
                    ArrayOfQuestion[i] = new MCQOneChoice();
                    ArrayOfQuestion[i].AddQuestion();
                }

                ArrayOfQuestion[i] = new TFQuestion();
                ArrayOfQuestion[i].AddQuestion();
            }

        }

        public override void ShowExam()
        {
            if(ArrayOfQuestion is not null )
            {
                foreach(Question question in ArrayOfQuestion)
                {
                    Console.WriteLine(question);
                    if(question is not null && question.AnswerList is not null)
                    {

                    for(int i = 0; i< question.AnswerList.Length; i++)
                            Console.WriteLine(question.AnswerList[i]);


                    int userAnswer;
                    do
                    {
                            Console.WriteLine("Enter Your Answer : ");
                        }
                    while (! int.TryParse(Console.ReadLine() , out userAnswer) && userAnswer < 1 || userAnswer > 3);

                    question.UserAnswer.AnswerId = userAnswer;
                    question.UserAnswer.AnswerText = question.AnswerList[userAnswer - 1].AnswerText;
                    Console.Clear();

                    }
                }

                int totalGrade = 0, Grade = 0;

                for(int i = 0; i < ArrayOfQuestion.Length; i++)
                {
                    totalGrade += ArrayOfQuestion[i].Mark;
                    if (ArrayOfQuestion[i].UserAnswer.AnswerId == ArrayOfQuestion[i].RightAnswer.AnswerId) 
                        Grade += ArrayOfQuestion[i].Mark;

                    Console.WriteLine($"Question {i+1} : {ArrayOfQuestion[i].Body}");
                    Console.WriteLine($"Right Answer {ArrayOfQuestion[i].RightAnswer}");

                }

                Console.WriteLine($"Your Grade is {Grade} Out Of {totalGrade} ");

            }
        }
    }
}
