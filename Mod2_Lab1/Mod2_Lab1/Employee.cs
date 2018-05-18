using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Employee
    {
        // creates integer variable called employeeCount and assigns a value to 1
        private static int employeeCount = 1;

        // private member variables
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //public properties
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        // constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }
        //method to return the emps base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        // this method returns the emp ID
        public int getEmployeeID()
        {
            return this.ID;
        }
        // returns emp id and name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }
        // method to return the emp id and name and confirms that the emp is in the system
        public virtual String employeeStatus()
        {
            return toString() + " is in the company's system";
        }       
        
    }
}
