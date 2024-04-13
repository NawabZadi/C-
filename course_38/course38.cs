using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee(){ID = 100, Name = "Amina", Salary = 5000, Experience = 5});
        empList.Add(new Employee(){ID = 100, Name = "Ibrar", Salary = 6000, Experience = 6});
        empList.Add(new Employee(){ID = 100, Name = "Aneesa", Salary = 2000, Experience = 2});
        empList.Add(new Employee(){ID = 100, Name = "Zakir", Salary = 7000, Experience = 7});

        Employee.PromoteEmployee(empList);

    }
}
delegate bool IsPromotabale(Employee empl);
class Employee
{
    public int ID{set; get;}
    public string Name{set; get;}
    public int Salary{set; get;}
    public int Experience{set; get;}

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotabale IsEliigibleToPromote)
    {
         foreach(Employee employee in employeeList)
         {
            if(IsEliigibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
         }
    } 
}