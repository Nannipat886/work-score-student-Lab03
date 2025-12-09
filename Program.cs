using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_score_student_Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Score Student");
                Console.Write("Enter a score between 0 and 100 (or type 'exit' to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                try
                {
                    int score = Int32.Parse(input);
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("Score must be between 0 and 100. Please try again.");
                        continue;
                    }
                    string grade;
                    if (score >= 80 && score <=100)
                    {
                        grade = "A";
                    }
                    else if (score >= 75 && score <=79)
                    {
                        grade = "B+";
                    }
                    else if (score >= 70 && score <=74)
                    {
                        grade = "B";
                    }
                    else if (score >= 65 && score<=69)
                    {
                        grade = "C+";
                    }
                    else if (score >= 60 && score <=64)
                    {
                        grade = "C";
                    }
                    else if (score >= 55 && score <=59)
                    {
                        grade = "D+";
                    }
                    else if (score >= 50 && score <=54)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }
                    Console.WriteLine($"The grade for a score of {score} is: {grade}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numeric score.");

                }

            }
        }
    }
}
