using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee 
            { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee 
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee 
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee 
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee 
            { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee 
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee 
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee 
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            // Returns the total count of employees whose gender matches
            // with the gender that is passed in.
            get
            {
                return listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            // Changes the gender of all employees whose gender matches
            // with the gender that is passed in.
            set
            {
                listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(x => x.Gender == gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}