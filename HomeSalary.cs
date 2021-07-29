using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class HomeSalary
    {
        static int CalculateHomeSalary(int salary)
        {
            int pf = 0;
            if (salary < 0)
            { return -1; }
            else if (salary <= 15000)
            {
                pf = 750;
            }
            else if (salary > 15000 & salary < 22000)
            {
                pf = 850;
            }
            else if (salary > 22000 & salary < 30000)
            {
                pf = 925;
            }
            else if (salary > 30000)
            {
                pf = 1000;
            }
            //Console.WriteLine(salary);
            //Console.WriteLine(pf);

            return (salary - pf - 678);

        }

        static void Main()
        {
            Console.WriteLine("Enter the salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(salary);
            int takehomesal = CalculateHomeSalary(salary);

            if (takehomesal == -1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("Take Home Salary: {0}", takehomesal);
            }
        }
    }
}
