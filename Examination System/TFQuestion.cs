using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
     class TFQuestion : Question
    {
        public override string? Header 
        { 
            get
            {
                return "True||False Question : ";
            }
        }
        public TFQuestion()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
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

            } while (!int.TryParse(Console.ReadLine(), out mark) && mark < 0);

            Mark = mark;

            int RightAns;
            do
            {
                Console.WriteLine("Enter Your Answer >>> 1 for 'True' , 2 for 'False' : ");

            } while (! int.TryParse(Console.ReadLine(),out RightAns) && RightAns < 1 || RightAns > 2);


            Console.Clear();

            
        }
    }
}
