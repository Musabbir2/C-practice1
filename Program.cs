using System;
namespace Inheritance
{
    class Branch
    {
        int BranchCode;
        string BranchName, BranchAddress;
        public void GetBranchData()
        {
            Console.WriteLine("Enter your Branch Details:-");
            Console.WriteLine("Enter your Branch code:");
            BranchCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Branch Name:");
            BranchName= Console.ReadLine();
            Console.WriteLine("Enter your Branch Address:");
            BranchAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine($"Your Branch code is: {BranchCode}");
            Console.WriteLine($"Your Branch Name is: {BranchName}");
            Console.WriteLine($"Your Branch Address is: {BranchAddress}");
        }
    }

    class Employee : Branch
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public void GetEmployeeData()
        {
            Console.WriteLine("Enter Employee Details:-");
            Console.WriteLine("Enter Employee Id:");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter age:");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Address:");
            EmployeeAddress = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine($"Employee ID is:{EmployeeId}");
            Console.WriteLine($"Employee Name is:{EmployeeName}");
            Console.WriteLine($"Employee Age is:{EmployeeAge}");
            Console.WriteLine($"Employee Address is:{EmployeeAddress}");
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            Employee x = new Employee();
            x.GetBranchData();
            x.DisplayBranchData();
            x.GetEmployeeData();
            x.DisplayEmployeeData();
            Console.WriteLine("Press Any key to Exit");
            Console.ReadKey();
        }
    }

}