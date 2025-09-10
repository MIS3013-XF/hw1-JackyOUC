// HW1b Grade

// Your Name:Jacky Chen
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            double studentID;
            double homeWork;
            double particaption;
            double test1;
            double test2;
            double test3;
            string studentIDasString;
            string homeWorkasString;
            string particaptionasString;
            string test1asString;
            string test2asString;
            string test3asString;

            Console.WriteLine("What is your first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("What is your StudentID: ");
            studentIDasString= Console.ReadLine();
            Console.WriteLine("What is your Overall percentage Grade for Homework: ");
            homeWorkasString= Console.ReadLine();
            Console.WriteLine("What is your Overall percentage Grade for Particaption: ");
            particaptionasString= Console.ReadLine();
            Console.WriteLine("What is your );
            homeWork = Convert.ToDouble(homeWorkasString);
            particaption = Convert.ToDouble(particaptionasString);
            test1 = Convert.ToDouble(test1asString);
            test2 = Convert.ToDouble(test2asString);
            test3 = Convert.ToDouble(test3asString);
            double finalGrade = (homeWork * 0.20) + (test1 * 0.15) + (test2 * 0.25) +(test3 * 0.25) + (particaption * 0.15);
            Console.WriteLine("----- Final Grade Report -----");
            Console.WriteLine("Student: " + FirstName + " " + LastName+"(" + +studentID +")" + " Your Final Grade is: " + finalGrade.ToString("F2") + "%");

            
            Console.ReadKey();
        }
    }
}
