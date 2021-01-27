using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class Data
    {
        public static List<Employee> Employees = new List<Employee>();
        public static void PrintEmployee()
        {
            Console.WriteLine("SEARCH EMPLOYEE\nPlease enter the employee ID");
            int key = Convert.ToInt32(Console.ReadLine());
            var emp = (from Employee in Employees where Employee.Id == key select Employee);
            Console.WriteLine("\nEmployee details searched (using where Clause in LINQ)\n");
            foreach (var i in emp)
            {
                Console.WriteLine(i);
            }
        }
        public static void SortAndPrintEmployees()
        {

            Employees.RemoveAt(Employees.Count-1);
            Data.Employees.Sort();
            Console.WriteLine("\nEmployee details after sorting(using ICOMPARABLE) with respect to their salaries \n");
            Data.Employees.ForEach(employee => Console.WriteLine(employee));

            

        }
        
    }
}