﻿using System;
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
            Student Asher = new Student(210456, "Asher Griess", "Computer Science", "United States", "Asher.Griess@trojans.dsu.edu", 6058462947, "3402 Hamburger Street");
            Asher.PrintStudentInfo();
            Asher.IsPrivate= true;
            Asher.PrintStudentInfo();
            Asher.Email = "gamer@gmail.com";
            foreach(var Change in Asher.History)
            {
                Console.Write(Change + "  ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
