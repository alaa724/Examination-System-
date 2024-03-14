using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumOfQuestions) : base(_Time, _NumOfQuestions)
        {
        }

        public override void CreateQuestions()
        {
            ArrayOfQuestion = new MCQOneChoice[NumOfQuestions];

            for (int i = 0; i < NumOfQuestions; i++)
            {
                    ArrayOfQuestion[i] = new MCQOneChoice();
                    ArrayOfQuestion[i].AddQuestion();
            }

        }

        public override void ShowExam()
        {
            if (ArrayOfQuestion is not null)
            {
                foreach (Question question in ArrayOfQuestion)
                {
                    Console.WriteLine(question);
                    if (question is not null && question.AnswerList is not null)
                    {

                        for (int i = 0; i < question.AnswerList.Length; i++)
                            Console.WriteLine(question.AnswerList[i]);


                        int userAnswer;
                        do
                        {
                            Console.WriteLine("Enter Your Answer : ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out userAnswer) && userAnswer < 1 || userAnswer > 3);

                        question.UserAnswer.AnswerId = userAnswer;
                        question.UserAnswer.AnswerText = question.AnswerList[userAnswer - 1].AnswerText;
                        Console.Clear();
                    }
                }

                Console.WriteLine("Right Answer ");
                for(int i =0; i< NumOfQuestions; i++)
                {
                    Console.WriteLine($"Question {i+1} : {ArrayOfQuestion[i].Body}");
                    Console.WriteLine($"Right Answer {i+1}  = {ArrayOfQuestion[i].RightAnswer} ");
                }
            }
        }
    }
}
