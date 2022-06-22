using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYROLL
{
    internal class Payroll
    {
        public static void Main(string[] args)
        {
            Employees employee1 = new Employees();
            Data data = new Data();


            Console.WriteLine("Welcome to your payroll:");
            int Opc1 = 1;

            List<Employees> employees = new List<Employees>();
            do
            {
                Console.WriteLine($"EMPLOYE: ");
                Console.WriteLine("1.Press if you want to enter the employee");
                Console.WriteLine("2.Press if you want to exit");
                Opc1 = int.Parse(Console.ReadLine());
                switch (Opc1)
                {
                    case 1:

                        Data.ReadEmplo(employee1);
                        Data.Calculate(employee1);
                        Data.PrintData(employee1);
                        employees.Add(employee1);
                        Data.Save(employees);

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
