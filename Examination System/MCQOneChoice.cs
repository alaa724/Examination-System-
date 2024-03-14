using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
     class MCQOneChoice : Question
    {
        public override string? Header 
        {
            get
            {
                return "Multiple Choice Question ";
            }
        }

        public MCQOneChoice()
        {
            AnswerList = new Answers[3];
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Enter The Question : ");

            do
            {
                Body = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(Body));

            int mark;
            do
            {
                Console.WriteLine("Enter The Mark Of The Question");

            } while (! int.TryParse(Console.ReadLine() , out mark) && mark < 0);

            Mark = mark;

            Console.WriteLine("Enter Choice : ");

            for(int i = 0; i< AnswerList?.Length; i++)
            {
                AnswerList[i] = new Answers { AnswerId = i + 1 };
                Console.WriteLine($"Enter Choice {i+1}");
                AnswerList[i].AnswerText = Console.ReadLine();

            }

            int RightAns;

            do
            {
                Console.WriteLine("Enter Id Od Right Answer :");

            } while (! int.TryParse(Console.ReadLine(),out RightAns) && RightAns < 1 || RightAns > 3);

            RightAnswer.AnswerId = RightAns;
            RightAnswer.AnswerText = AnswerList?[RightAns - 1].AnswerText;

            Console.Clear();
        }
    }
}
