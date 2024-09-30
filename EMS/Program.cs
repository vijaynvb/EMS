using EMS.Implementation;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Program
    {

        public static void Main()
        {
            EmployeStaticImp employeeImp = new EmployeStaticImp();

            Console.WriteLine("Welcome to EMS Application");
            int userOperation = 0;
            do
            {
                Console.WriteLine("Select your optins " +
                    "\n 1-Create employee" +
                    "\n 2-Update employee" +
                    "\n 3-Get employee by id" +
                    "\n 4-Delete employee" +
                    "\n 5-Get All Employees" +
                    "\n 6-Exit");
                userOperation = Convert.ToInt32(Console.ReadLine());

                switch (userOperation)
                {
                    case 1:
                        // name and age should be capture from user 
                        int empid = Utils.ReadInt("Enter EmployeeId: ");
                        string name = Utils.ReadString("Enter name:");
                        int age = Utils.ReadInt("Enter Age: ");
                        Employee newEmployee = new Employee(empid, name, age);
                        employeeImp.AddEmployee(newEmployee);
                        break;
                    case 2:
                        int empid1 = Utils.ReadInt("Enter EmployeeId: ");
                        int age1 = Utils.ReadInt("Enter Age: ");
                        var emp = employeeImp.UpdateEmployee(empid1, age1);
                        if (emp != null)
                            Console.WriteLine("Employee {0} Updated successfully", emp.Name);
                        break;
                    case 3:
                        int empid2 = Utils.ReadInt("Enter EmployeeId: ");
                        Employee emp2 = employeeImp.GetEmployeeById(empid2);
                        Console.WriteLine("Id: {0} Employee Name: {1}",emp2.Id,emp2.Name);
                        break;
                    case 4:
                        int empid3 = Utils.ReadInt("Enter EmployeeId: ");
                        var emp1 = employeeImp.DeleteEmployee(empid3);
                        if (emp1 != null)
                            Console.WriteLine("Employee {0} deleted successfully", emp1.Name);
                        break;
                    case 5:
                        List<Employee> employees = employeeImp.GetEmployees();
                        employees.ForEach(emp => Console.WriteLine(emp.Name));
                        break;
                    case 6:
                        Console.WriteLine("Thank you");
                        break;
                }

            } while (userOperation != 6);

        }
    }

    class Utils
    {
        public static int ReadInt(string message)
        {
            Console.Write(message);
            int intval = Convert.ToInt32(Console.ReadLine());
            return intval;
        }
        public static string ReadString(string message)
        {
            Console.Write(message);
            string stringval = Console.ReadLine();
            return stringval;
        }
    }
}
