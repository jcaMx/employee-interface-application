using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public interface IEmployee
    {
        // Properties
        string FirstName { get; set; }
        string LastName { get; set; }
        string JobTitle { get; set; }

        // Method
        double ComputeSalary(double hoursWorked, double ratePerHour);
    }
   
    public class PartTimeEmployee : IEmployee
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        // Additional Properties as per UserInfo
        public string Department { get; set; }

        // Constructor
        public PartTimeEmployee(string firstName, string lastName, string jobTitle, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Department = department;
            
        }

        // Method to calculate salary based on hours worked and rate per hour
        public double ComputeSalary(double hoursWorked, double ratePerHour)
        {
            return hoursWorked * ratePerHour;
        }
    }
    



}


