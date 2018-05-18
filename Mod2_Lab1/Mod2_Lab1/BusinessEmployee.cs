using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    //businessEmployee class inherits from Employee class
    class BusinessEmployee : Employee
    {
        //creates a double variable called bonusBudget and assigns value to 1000
        public double bonusBudget = 1000;

        //uses the Employee class constructor from within the derived class (BusinessEmployee Class)
        // sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(String name) : base(name, 50000)
        {
        }
        // this method returns the toString() method(employee id and name) and prints the bonus budget
        public override string employeeStatus()
        {
            return toString() + " with a budget of $" + this.bonusBudget;
        }
    }
}
