using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateQA
{
    public class Employee
    {
        //Class variables
        int employeeNumber;
        String firstName;
        String lastName;
        DateTime dateOfHire;
        String jobDescription;
        String department;
        float monthlySalary;

        public Employee(int employeeId, String fname, String lname)
        {
            this.employeeNumber = employeeId;
            this.firstName = fname;
            this.lastName = lname;


        }


        //setters and getters or properties
        public int EmployeeId
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName { get { return lastName; } set { lastName = value; } }
        public String JobDescription { get { return jobDescription; } set { jobDescription = value; } }
        public String Department { get { return department; } set { department = value; } }
        public float MonthlySalary { get { return monthlySalary; } }

        public String fullNameOfEmployee()
        {
            return firstName + " " + lastName;
        }

        public String returnFormattableNameOfEmployee()
        {
            return lastName + ", " + firstName;
        }
    
}
}
