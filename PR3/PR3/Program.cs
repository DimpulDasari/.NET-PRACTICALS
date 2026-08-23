using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    internal class Program
    {
        // Static Variables
        static List<string> expenses = new List<string>();
        static double totalExpense = 0;

        // Static Constructor
        static Program()
        {
            Console.WriteLine("Welcome to Expense Tracking System");
            Console.WriteLine("-----------------------------------");
        }

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n============== MENU ==============");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice : ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter Expense ID : ");
                            int expenseId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Category   : ");
                            string category = Console.ReadLine();

                            Console.Write("Enter Amount     : ");
                            double amount = Convert.ToDouble(Console.ReadLine());

                            if (amount <= 0)
                            {
                                throw new Exception("Expense amount must be greater than 0.");
                            }

                            Console.WriteLine("\nSelect Payment Method");
                            Console.WriteLine("1. Cash");
                            Console.WriteLine("2. UPI");
                            Console.WriteLine("3. Card");
                            Console.Write("Enter Choice : ");
                            int paymentChoice = Convert.ToInt32(Console.ReadLine());

                            string paymentMethod;

                            if (paymentChoice == 1)
                            {
                                paymentMethod = "Cash";
                            }
                            else if (paymentChoice == 2)
                            {
                                paymentMethod = "UPI";
                            }
                            else if (paymentChoice == 3)
                            {
                                paymentMethod = "Card";
                            }
                            else
                            {
                                throw new Exception("Invalid Payment Method.");
                            }

                            totalExpense += amount;

                            expenses.Add(
                                "Expense ID : " + expenseId +
                                " | Category : " + category +
                                " | Amount : Rs. " + amount +
                                " | Payment : " + paymentMethod);

                            Console.WriteLine("\n-----------------------------------");
                            Console.WriteLine("      EXPENSE ADDED SUCCESSFULLY");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("Expense ID     : " + expenseId);
                            Console.WriteLine("Category       : " + category);
                            Console.WriteLine("Amount         : Rs. " + amount);
                            Console.WriteLine("Payment Method : " + paymentMethod);
                            Console.WriteLine("-----------------------------------");

                            break;

                        case 2:

                            Console.WriteLine("\n============== ALL EXPENSES ==============");

                            if (expenses.Count == 0)
                            {
                                Console.WriteLine("No Expenses Found.");
                            }
                            else
                            {
                                Console.WriteLine("---------------------------------------------------------------");

                                foreach (string expense in expenses)
                                {
                                    Console.WriteLine(expense);
                                }
                            }

                            break;

                        case 3:

                            Console.WriteLine("\n========== TOTAL EXPENSE ==========");
                            Console.WriteLine("Total Expense : Rs. " + totalExpense);
                            Console.WriteLine("-----------------------------------");

                            break;

                        case 4:

                            Console.WriteLine("\n=============== EXIT ===============");
                            Console.WriteLine("Total Expense : Rs. " + totalExpense);
                            Console.WriteLine("Thank You!! Visit Again.");
                            Console.WriteLine("-----------------------------------");

                            break;

                        default:

                            Console.WriteLine("Invalid Choice! Please Try Again.");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError : Please enter a valid number.");
                    choice = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError : " + ex.Message);
                    choice = 0;
                }
                finally
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Operation Completed.");
                    Console.WriteLine("--------------------------------------");
                }

            } while (choice != 4);
        }
    }
}
