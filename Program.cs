using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender:");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (in format dd/mm/yyyy):");
            DateTime joiningDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Date of Joining: {0}", joiningDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("\nEmployee Salary:");
            Console.WriteLine(salary);

            double taxRate = (salary > 90000) ? 0.3 : 0.15;
            double taxAmount = salary * taxRate;
            double netSalary = salary - taxAmount;

            Console.WriteLine("\nYou have to pay:");
            Console.WriteLine(joiningDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tax Rate: {0:P}", taxRate);
            Console.WriteLine("Tax Amount: {0:C}", taxAmount);
            Console.WriteLine("Net Salary: {0:C}", netSalary);
        }
    }
}