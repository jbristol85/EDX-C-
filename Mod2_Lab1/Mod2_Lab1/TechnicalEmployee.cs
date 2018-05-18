using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // technical employee class inheriting from employee class
    class TechnicalEmployee : Employee
    {
        //creates int variable called successfulCheckIns and assigns value to 5
        public int successfulCheckIns = 5;

        //call upon the base-class(emp class) constructor within the derived class(technicalemployee class)
        //sets baseSalary to 75000 for all technical Employee objects
        public TechnicalEmployee(String name) : base(name, 75000)
        {          
        }

        //this method returns the toString() method(emp ID and name) and prints the number of successful checkins the emp has has
        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
