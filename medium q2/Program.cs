using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Employees.Add(new Employee());
            for (int i=0;;i++ )
            {
                int res=Data.Employees.ElementAt(i).TakeEmployeeDetailsFromUser();
                if (res == 1)
                {
                    Console.WriteLine("Duplicate Employee ID !!!!");
                    i--;
                    
                }
                else
                {
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                        continue;
                    else if (choice == 0)
                    {
                        Data.SortAndPrintEmployees();
                        Data.PrintEmployee();
                        break;
                    }

                    else
                        Console.WriteLine("Wrong input ");

                }
                
            }


            Console.ReadKey();

        }
    }
}
