using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    public class Employee
    {
        double salary;
        string empNumber, jobTitle, name, surname; // no direct access to variables

        // method is called by main method to read variables
        public Employee(double salary, string empNumber, string jobTitle, string name, string surname)
        {
            this.salary = salary;
            this.empNumber = empNumber;
            this.jobTitle = jobTitle;
            this.name = name;
            this.surname = surname;
        }

        public object this[int index]
        {
            // gets position they sent to display
            get
            {
                if (index == 0)
                    return this.empNumber;
                else if (index == 1)
                    return this.jobTitle;
                else if (index == 2)
                    return this.name;
                else if (index == 3)
                    return this.surname;
                else if (index == 4)
                    return this.salary;
                return null;
            }

            set
            {
                if (index == 0)
                    this.empNumber = (string)value;
                else if (index == 1)
                    this.jobTitle = (string)value;
                else if (index == 2)
                    this.name = (string)value;
                else if (index == 3)
                    this.surname = (string)value;
                else if (index == 4)
                    this.salary = (double)value;
                
            }
        }

        // Accessing indexer with variable or position
        //To access position
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("empNumber"))
                    return this.empNumber;
                if (attrName.ToLower().Equals("jobTitle"))
                    return this.jobTitle;
                if (attrName.ToLower().Equals("name"))
                    return this.name;
                if (attrName.ToLower().Equals("surname"))
                    return this.surname;
                if (attrName.ToLower().Equals("salary"))
                    return this.salary;
                return null;

            }

            set
            {
                if (attrName.ToLower().Equals("empNumber"))
                    this.empNumber = (string)value;
                if (attrName.ToLower().Equals("jobTitle"))
                    this.jobTitle= (string)value;
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                if (attrName.ToLower().Equals("salary"))
                    this.salary = (double)value;
            }
        }
    }
}
