using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book= new Book("First Book"); 

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(79.8);
            book.AddGrade(85.6); 

            var stats = book.GetStatistics(); 

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Avarage:N1}"); 
        }
    }
}
