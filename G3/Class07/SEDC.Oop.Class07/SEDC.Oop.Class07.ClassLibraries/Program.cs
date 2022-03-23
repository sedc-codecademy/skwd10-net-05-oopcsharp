using SEDC.Oop.Class07.Sevices;
using System;

namespace SEDC.Oop.Class07.ClassLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.CreateObjectAndWriteInConsole();

            Console.ReadLine();
        }
    }
}
