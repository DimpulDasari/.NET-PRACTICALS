using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Employee
    {
        public int Empid;
        public string EmpName;
        public int BasicSalary;

        public Employee()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Employee Salary Payroll");
            Console.WriteLine("-----------------------------------");
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            BasicSalary = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            Console.WriteLine("EmployeeID: " + Empid);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Employee Basic Salary: " + BasicSalary);
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary Calculation");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double HRA = BasicSalary * 0.20;
            double DA = BasicSalary * 0.10;
            double NetSalary = BasicSalary + HRA + DA;
            Console.WriteLine("Employee Job type: FullTimeEmployee");
            Console.WriteLine("Employee Salary: " + NetSalary);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double NetSalary = BasicSalary;
            Console.WriteLine("Employee Job type: PartTimeEmployee");
            Console.WriteLine("Employee Salary: " + NetSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Employee e1 = null;
            if (choice == 1)
            {
                e1 = new FullTimeEmployee();
            }
            else if (choice == 2)
            {
                e1 = new PartTimeEmployee();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            e1.AcceptDetails();
            e1.DisplayDetails();
            e1.CalculateSalary();
            Console.ReadKey();
        }
    }
}
