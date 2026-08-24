//using oops concept-class,object,constructor and 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetStudentDetails();
            Console.WriteLine("=========================");
            student.DisplayStudentData();
            Console.ReadKey();
        }
    }
    public class Student
    {
        public int grno;
        public string name;
        public string dept;
        public int sem;
        private double fees;

        public Student()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Object of class student is created:");
            Console.WriteLine("-----------------------------------");
        }
        public void GetStudentDetails()
        {
            Console.Write("Enter stuednt Grno:");
            grno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student name:");
            name = Console.ReadLine();
            Console.Write("Enter student Department:");
            dept = Console.ReadLine();
            Console.Write("Enter student sem:");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student fees:");
            fees = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStudentData()
        {
            Console.WriteLine("Student Grno is:" + grno);
            Console.WriteLine("Student Name is :" + name);
            Console.WriteLine("Student is enrolled in:" + dept);
            Console.WriteLine("Student is in:" + sem);
            Console.WriteLine("Student fees:" + fees);

            Eligiblity();
        }
        public void Eligiblity()
        {
            Console.WriteLine("-------Check scholarship Status------");
            if (fees <= 50000)
            {
                double scholarship = fees * 0.10;
                Console.WriteLine("Student is Eligible for scholarship");
                Console.WriteLine("Scholarship of:" + scholarship);
                Console.WriteLine("Total payable Fees:" + (fees - scholarship));
            }
            else
            {
                Console.WriteLine("Student is not eligible for scholarship");
            }
        }
    }
}
