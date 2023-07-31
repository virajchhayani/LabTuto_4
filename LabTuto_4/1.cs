using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    public class Employee
    {
        // Properties
        public int EmployeeCode { get; private set; }
        public string Name { get; private set; }
        public string Designation { get; private set; }
        public double BasicPay { get; private set; }
        // Constructor
        public Employee(int employeeCode, string name, string designation, double basicPay)
        {
            EmployeeCode = employeeCode;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }
        // Methods to calculate HRA, DA, and Total Pay
        public double CalculateHRA()
        {
            return 0.10 * BasicPay;
        }
        public double CalculateDA()
        {
            return 0.45 * BasicPay;
        }
        public double CalculateTotalPay()
        {
            return BasicPay + CalculateHRA() + CalculateDA();
        }
        // Method to print employee details, HRA, DA, and Total Pay
        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee Code : {EmployeeCode}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Designation : {Designation}");
            Console.WriteLine($"Basic Pay : {BasicPay:C2}");
            Console.WriteLine($"HRA : {CalculateHRA():C2}");
            Console.WriteLine($"DA : {CalculateDA():C2}");
            Console.WriteLine($"Total Pay : {CalculateTotalPay():C2}");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            // Creating objects for three different employees
            Employee employee1 = new Employee(1001, "Viraj", "Manager", 50000);
            Employee employee2 = new Employee(1002, "Jeet", "Engineer", 35000);
            Employee employee3 = new Employee(1003, "Yash", "Analyst", 40000);
            // Calculating and printing HRA, DA, and Total Pay for each employee
            Console.WriteLine("Details for Employee 1 : ");
            employee1.PrintEmployeeDetails();
            Console.WriteLine("Details for Employee 2 : ");
            employee2.PrintEmployeeDetails();
            Console.WriteLine("Details for Employee 3 : ");
            employee3.PrintEmployeeDetails();
        }
    }
}
