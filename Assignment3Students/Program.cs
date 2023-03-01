using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Students
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student Asher = new Student(210456, "Asher Kendall", "Computer Science", "United States", "Asher.Kendall@trojans.dsu.edu", 6058462947, "3402 Hamburger Street");
            Asher.PrintStudentInfo();
            Asher.Email = "gamer@gmail.com";
            Console.Write("Asher: ");
            Asher.PrintStudentChanges();

            Student James = new Student(893785, "James Banes","Cyber Security", "Canada", "James.Banes@trojans.dsu.edu", 8945672035, "345 Bruh Ave");
            James.IsPrivate = true;
            James.PrintStudentInfo();
            Console.WriteLine(James.Email);
            James.Email = "bruh@games.";
            James.Email = "bruh@games.io";
            James.Country = "United States";
            James.Major = "Game Design";
            James.PrintStudentInfo();
            James.PrintStudentChanges();

            Student Jones = new Student(893785, "Jones Banes", "Cyber Security", "Canada", "Jones.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Jones.PrintStudentInfo();

            Student Bob = new Student(893785, "Bob Banes", "Cyber Security", "Canada", "Bob.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Bob.PrintStudentInfo();

            Student Dave = new Student(893785, "Dave Banes", "Cyber Security", "Canada", "Dave.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Dave.PrintStudentInfo();

            Student Aiden = new Student(893785, "Aiden Banes", "Cyber Security", "Canada", "Aiden.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Aiden.PrintStudentInfo();

            Student Andrew = new Student(893785, "Andrew Banes", "Cyber Security", "Canada", "Andrew.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Andrew.PrintStudentInfo();

            Student Man = new Student(893785, "Man", "Cyber Security", "Canada", "Man@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Man.PrintStudentInfo();

            Student Kevin = new Student(893785, "Kevin Banes", "Cyber Security", "Canada", "Kevin.Banes@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            Kevin.PrintStudentInfo();

            Student SusGuy = new Student(893785, "Sus Guy", "Cyber Security", "Canada", "Sus.Gus@trojans.dsu.edu", 8945572035, "345 Bruh Ave");
            SusGuy.PrintStudentInfo();

            Console.ReadLine();
        }
    }
}
