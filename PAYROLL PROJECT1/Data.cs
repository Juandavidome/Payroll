using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PAYROLL_PROJECT1
{
    internal class Data
    {
        public static Employee ReadEmployee(Employee employee)
        {

            try
            {
                Console.WriteLine("Insert the document:");
                employee.DocumentId =  Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the Name:");
                employee.Name = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the Last Name:");
                employee.LastName = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the salary:");
                employee.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Insert the days worked:");
                employee.WorkedDays = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            catch (FormatException e)
            {
                Console.WriteLine("El value no is valid. Insert other value", e);
                Console.ReadKey();
            }

            return employee;
        }

        public static Employee CalculateValues(Employee employee)
        {
            int Days = 30;
            int PriceAuxTransport = 117172;
            int ConditionSalary = 2000000;
            double Percentage = 0.04;

            employee.TotalAccrued = employee.Salary / Days;
            employee.TotalAccrued = employee.TotalAccrued * employee.WorkedDays;

            employee.AuxTransport = PriceAuxTransport / Days;
            employee.AuxTransport = employee.AuxTransport * employee.WorkedDays;

            employee.Health = employee.TotalAccrued * Percentage;
            employee.Pension = employee.TotalAccrued * Percentage;

            if (employee.Salary <= ConditionSalary)
            {
                employee.TotalAccrued = employee.TotalAccrued + employee.AuxTransport;
            }
            else
            {
                employee.TotalAccrued = employee.TotalAccrued;
            }

            return employee;
        }

        public static Employee PrintDataEmployee(Employee employee)
        {
            Console.WriteLine($"Document number:{employee.DocumentId} ");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Worked Days: {employee.WorkedDays}");
            Console.WriteLine($"Total Accrued: {employee.TotalAccrued}");
            Console.WriteLine($"Health: {employee.Health}");
            Console.WriteLine($"Pension: {employee.Pension}");
            return employee;
        }

        public static void SaveToFile(List<Employee> employee)
        {
            string FileName = "C:\\Employee.txt";
            try
            {
                string json = JsonConvert.SerializeObject(employee, Formatting.Indented);
                File.WriteAllText(FileName, json);
                Console.WriteLine("Data was saved");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error to save the program", e);

            }
        }
    }
}
