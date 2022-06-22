using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PAYROLL
{
    internal class Data
    {
        public static Employees ReadEmplo(Employees employee1)
        {

            try
            {
                Console.WriteLine("Insert the document:");
                employee1.DocumentId = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the Name:");
                employee1.Name = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the Last Name:");
                employee1.LastName = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Insert the salary:");
                employee1.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Insert the days worked:");
                employee1.WorkedDays = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("El value no is valid"+ exception);
                Console.ReadKey();
            }

            return employee1;
        }

        public static Employees Calculate(Employees employee1)
        {
            
           

            employee1.TotalAccrued = employee1.Salary / 30;
            employee1.TotalAccrued = employee1.TotalAccrued * employee1.WorkedDays;

            employee1.AuxTransport = 117172 / 30;
            employee1.AuxTransport = employee1.AuxTransport * employee1.WorkedDays;

            employee1.Health = employee1.TotalAccrued * 0.4;
            employee1.Pension = employee1.TotalAccrued * 0.4;

            if (employee1.Salary <= 2000000)
            {
                employee1.TotalAccrued = employee1.TotalAccrued + employee1.AuxTransport;
            }
            else
            {
                employee1.TotalAccrued = employee1.TotalAccrued;
            }

            return employee1;
        }

        public static Employees PrintData(Employees employee1)
        {
            Console.WriteLine($"Document number:{employee1.DocumentId} ");
            Console.WriteLine($"First Name: {employee1.Name}");
            Console.WriteLine($"Last Name: {employee1.LastName}");
            Console.WriteLine($"Salary: {employee1.Salary}");
            Console.WriteLine($"Worked_Days: {employee1.WorkedDays}");
            Console.WriteLine($"Total Accrued: {employee1.TotalAccrued}");
            Console.WriteLine($"Health: {employee1.Health}");
            Console.WriteLine($"Pension: {employee1.Pension}");
            return employee1;
        }

        public static void Save(List<Employees> employee1)
        {
            string Name1 = "C:\\Employee.txt";
            try
            {
                string Json = JsonConvert.SerializeObject(employee1, Formatting.Indented);
                File.WriteAllText(Name1, Json);
             
            }
            catch (Exception exception)
            {
                Console.WriteLine("ERROR", exception);

            }
        }
    }
}