namespace TestProgram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class _02Test
    {
        static void Main()
        {
            List<Student> testStudents = new List<Student>()
            {
                new Student("Richard", "Feynman", 6),
                new Student("Isaac", "Newton", 6),
                new Student("Paul", "Dirac", 5),
                new Student("Niels", "Bohr", 4),
                new Student("Albert", "Einstein", 6),
                new Student("Werner", "Heisenberg", 6),
                new Student("Max", "Planck", 5),
                new Student("Marie", "Curie", 6),
                new Student("Edwin", "Hubble", 5),
                new Student("Jocelyn", "Bell", 6)
            };
            Console.WriteLine("\n____________ Students ".PadRight(100, '_'));
            foreach (var s in testStudents)
            {
                Console.WriteLine(s);
            }
            var studentsSortedByGrade = testStudents.OrderBy(s => s.Grade);
            Console.WriteLine("\n____________ Students sorted by grade in ascending order ".PadRight(100, '_'));
            foreach (var s in studentsSortedByGrade)
            {
                Console.WriteLine(s);
            }
            List<Worker> testWorkers = new List<Worker>()
            {
                new Worker("Gustave", "Eiffel", 500M, 8),
                new Worker("Alfred", "Nobel", 450, 8),
                new Worker("Henry", "Ford", 700M, 8),
                new Worker("Hedy", "Lamarr", 700M, 6),
                new Worker("Lillian", "Gilbreth", 400M, 4),
                new Worker("James", "Watt", 1000M, 8),
                new Worker("Henry", "Bessemer", 500M, 5),
                new Worker("Marissa", "Mayer", 2000M, 8),
                new Worker("Seymour", "Cray", 1500M, 12),
                new Worker("Edith", "Clarke", 1200M, 10)
            };
            Console.WriteLine("\n____________ Workers ".PadRight(100, '_'));
            foreach (var w in testWorkers)
            {
                Console.WriteLine(w);
            }
            var studentsSortedByMoneyPerHour = testWorkers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("\n____________ Workers sorted by money per hour in descending order ".PadRight(100, '_'));
            foreach (var w in studentsSortedByMoneyPerHour)
            {
                Console.WriteLine(w);
            }
            var humanStudents = testStudents.Select(s => s as Human);
            var humanWorkers = testWorkers.Select(w => w as Human);


            var joinedStudentsWorkers = humanStudents.Concat(humanWorkers).OrderBy(h1 => h1.FirstName.ToLower()).ThenBy(h2 => h2.LastName.ToLower());
            Console.WriteLine("\n____________ Students and workers sorted by first and last name ".PadRight(100, '_'));
            foreach (var h in joinedStudentsWorkers)
            {
                Console.WriteLine(h);
            }
        }
    }
}
