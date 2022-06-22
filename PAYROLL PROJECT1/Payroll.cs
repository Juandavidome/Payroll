using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYROLL_PROJECT1
{
    internal class Payroll
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Data data = new Data();
            

            Console.WriteLine("Welcome to your payroll:");
            int Opc1 = 1;
            
            List<Employee> employees = new List<Employee>();
            do
            {
                Console.WriteLine($"EMPLOYE: ");
                Console.WriteLine("1.Press if you want to enter the employee");
                Console.WriteLine("2.Press if you want to exit");
                Opc1 = int.Parse(Console.ReadLine());
                switch (Opc1)
                {
                    case 1:

                        Data.ReadEmployee(employee);
                        Data.CalculateValues(employee);
                        Data.PrintDataEmployee(employee);
                        employees.Add(employee);
                        Data.SaveToFile(employees);

                        break;
                    case 2:
                        Console.WriteLine("__________________________________________________");
                        Console.WriteLine("Exit the program");
                        break;
                    default:
                        Console.WriteLine("The option not is valid. ");
                        break;

                }
                Console.ReadKey();

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Clear();
              
            } while (Opc1 != 2);
        }
    }
}
