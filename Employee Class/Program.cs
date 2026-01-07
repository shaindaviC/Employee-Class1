using System;
using System.Collections;

public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        EmployeeID = id;
        EmployeeName = name;
        Salary = salary;
    }
}

class employeeDal
{
    ArrayList employeeList = new ArrayList();
    public bool AddEmployee(Employee e)
    {
        if (e == null)
            return false;
        employeeList.Add(e);
        return true;
    }
    public bool DeleteEmployee(int id)
    {
        foreach (Employee e in employeeList)
        {
            if (e.EmployeeID == id)
            {
                employeeList.Remove(e);
                return true;
            }
        }
        return false;
    }
    public string SearchEmployee(int id)
    {
        foreach (Employee e in employeeList)
        {
            if (e.EmployeeID == id)
            {
                return e.EmployeeName;
            }
        }
        return null;
    }
    public Employee[] GetAllEmployeesListAll()
    {
        Employee[] empArray = new Employee[employeeList.Count];
        employeeList.CopyTo(empArray);
        return empArray;
    }
}

class program
{
    static void Main()
    {
        employeeDal dal = new employeeDal();
        dal.AddEmployee(new Employee(1, "Siva", 25000));
        dal.AddEmployee(new Employee(2, "Harini", 30000));
        Console.WriteLine(dal.SearchEmployee(1));
        dal.DeleteEmployee(2);
        Employee[] employees = dal.GetAllEmployeesListAll();
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.EmployeeID + " " + emp.EmployeeName + " " + emp.Salary);
        }
    }
}