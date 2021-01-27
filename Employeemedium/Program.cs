using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeemedium
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0; int findage; var f_age = 0;
            IDictionary<int, Tuple<String, int, Double>> Employees = new Dictionary<int, Tuple<String, int, Double>>();
            Employee emp = new Employee();
            do
            {
                emp.TakeEmployeeDetailsFromUser();
                Employees.Add(emp.Id, Tuple.Create(emp.Name, emp.Age, emp.Salary));
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                check = Convert.ToInt32(Console.ReadLine());
            } while (check == 1);

            //1.Question1
            Console.WriteLine("Please enter the employee ID");
            int idno = Convert.ToInt32(Console.ReadLine());
            foreach (var employee in Employees)
            {
                if (employee.Key == idno)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", employee.Key, employee.Value.Item1, employee.Value.Item2, employee.Value.Item3);
                }

            }

            //2.Sorted List And Print the employee details using employee id
            foreach (var list in Employees.OrderBy(i => i.Value.Item3))
            {
                Console.WriteLine("The Sorted Employee List:");
                Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", list.Key, list.Value.Item1, list.Value.Item2, list.Value.Item3);
                Console.WriteLine("-------------------");
            }
            foreach (var employee in Employees)
            {
                if (employee.Key == idno)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", employee.Key, employee.Value.Item1, employee.Value.Item2, employee.Value.Item3);
                }

            }

            //3. Print the employee details using employee name
            var name = Console.ReadLine();
            foreach (var emp1 in Employees)
            {
                if (emp1.Value.Item1 == name)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", emp1.Key, emp1.Value.Item1, emp1.Value.Item2, emp1.Value.Item3);
                }

            }
            //Elder Employee



            Console.WriteLine("Please enter the employee ID");
            findage = Convert.ToInt32(Console.ReadLine());
            foreach (var employee in Employees)
            {
                if (employee.Key == findage)
                {
                    f_age = employee.Value.Item2;
                }

            }

            foreach (var employee in Employees)
            {
                if (f_age < employee.Value.Item2)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", employee.Key, employee.Value.Item1, employee.Value.Item2, employee.Value.Item3);
                }
            }
            Console.ReadKey();
        }
    }

}
    

