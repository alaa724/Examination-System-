using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            Subject Sub = new Subject(10,"C#");
            Sub.CreateExam();

            
            
            Console.WriteLine("Do You Want To Start Exam : Y | N ");
            char input = char.Parse(Console.ReadLine());
            
            if (input == 'Y' || input == 'y')
            {
                Stopwatch SW = new();
                SW.Start();
                Sub.ExamSubj?.ShowExam();
                Console.WriteLine($"The Time is {SW.Elapsed}");
            }
            else if(input == 'N' || input == 'n')
                Console.WriteLine("Thanks :)");


        }
    }
}
