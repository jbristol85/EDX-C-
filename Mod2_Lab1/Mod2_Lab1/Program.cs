using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates employee object with the name Libby and salary of 2000 called employee 1
            var employee1 = new Employee("Libby", 2000);
            // instantiates TechnicalEmployee object with the name Zaynah called Employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            // instantiates BusinessEmployee object with the name "Winter" called Employee3
            var employee3 = new BusinessEmployee("Winter");

            //output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
