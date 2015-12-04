//namespace _02.Salaries
//{
//    using System;
//    using System.Linq;

//    public class Program
//    {
//        public static void Main()
//        {
//            int totalEmployees = int.Parse(Console.ReadLine());
//            var connections = new long[totalEmployees];
//            for (int i = 0; i < totalEmployees; i++)
//            {
//                var input = Console.ReadLine().Trim();

//                connections[i] = Convert.ToInt64(input.Replace('Y', '1').Replace('N', '0'), 2);
//            }

//            // take all leafs salaries
//            var children = new long[totalEmployees];
//            for (int i = 0; i < connections.Length; i++)
//            {
//                if (connections[i] == 0)
//                {
//                    children[i] = 1;
//                }
//            }


//            long totalSum = 0;
//            for (int k = 0; k < connections.Length; k++) // connections are all the relations between an employee and the others
//            {
//                for (int i = 0; i < children.Length; i++)
//                {
//                    bool foundParent = false;
//                    if (children[i] != 0)
//                    {
//                        for (int j = 0; j < connections.Length; j++)
//                        {
//                            if (((connections[j] >> totalEmployees - i - 1) & 1) == 1) // if some connection points to the current child (has 'Y' at the same index as the child's index) => it's a parent of the child
//                            {
//                                children[j] += children[i]; // transfer the salary of the child to the salary of the parent
//                                foundParent = true;
//                            }
//                        }
//                        if (foundParent)
//                        {
//                            totalSum += children[i]; // found all immediate parents of a child => remove it from future calculations, but save its salary to the total
//                            children[i] = 0;
//                            break;
//                        }
//                    }
//                }
//            }

//            totalSum += children.Sum();

//            Console.WriteLine(totalSum);
//        }
//    }
//}

namespace _02.Salaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee
    {
        public Employee()
        {
            this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }

        public int Salary
        {
            get
            {
                return this.Employees.Count == 0 ? 1 : this.Employees.Select(e => e.Salary).Sum();
            }
        }

        public void AddEmployee(Employee e)
        {
            this.Employees.Add(e);
        }
    }

    public class Program
    {
        public static void Main()
        {
            int totalEmployees = int.Parse(Console.ReadLine());
            var employees = new Employee[totalEmployees];

            for (int i = 0; i < totalEmployees; i++)
            {
                employees[i] = new Employee();
            }

            for (int i = 0; i < totalEmployees; i++)
            {
                var input = Console.ReadLine().Trim();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'Y')
                    {
                        employees[i].AddEmployee(employees[j]);
                    }
                }
            }

            Console.WriteLine(employees.Select(e => e.Salary).Sum());
        }
    }
}