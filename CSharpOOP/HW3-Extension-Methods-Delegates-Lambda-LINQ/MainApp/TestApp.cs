﻿namespace MainApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class TestApp
    {
        public static void Main()
        {
            Console.WriteLine("\n______________ check extending StringBuilder with substring (task 1) ".PadRight(80, '_'));
            StringBuilder testStr = new StringBuilder("Freddie Mercury");
            Console.WriteLine(testStr);
            StringBuilder testSubstr = testStr.Substring(8, 7);
            Console.WriteLine(testSubstr);
            Console.WriteLine("\n______________ check extending IEnumerable<T> (task 2)".PadRight(80, '_'));
            int[] testArr = new int[] { 5, 2, 3 };
            //double[] testArr = new double[] { 1.5, 2.5, 3.6 };
            //char[] testArr = new char[] { 'F', 'r', 'e', 'd', 'd', 'i', 'e' };
            Console.WriteLine("array = {0}", string.Join(" ", testArr));
            Console.WriteLine("sum = {0}", testArr.SumExt());
            Console.WriteLine("product = {0}", testArr.ProductExt());
            Console.WriteLine("min = {0}", testArr.MinExt());
            Console.WriteLine("max = {0}", testArr.MaxExt());
            Console.WriteLine("avg = {0}", testArr.AvgExt());
            Console.WriteLine("\n______________ check searching/sorting students with LINQ and Lambda (tasks 3-5) ".PadRight(80, '_'));
            int ageAdjustment1975 = 40;
            Student[] testStudents = new Student[] 
            {
                new Student("Freddie", "Mercury", 68 - ageAdjustment1975),
                new Student("Brian", "May", 67 - ageAdjustment1975),
                new Student("Roger", "Taylor", 65 - ageAdjustment1975),
                new Student("John", "Deacon", 63 - ageAdjustment1975),
                new Student("Mike", "Grose", 60 - ageAdjustment1975),
                new Student("Barry", "Mitchell", 68 - ageAdjustment1975),
                new Student("Doug", "Bogie", 60 - ageAdjustment1975)
            };
            Console.WriteLine("\n\t Students array:");
            for (int i = 0; i < testStudents.Length; i++)
            {
                Console.WriteLine(testStudents[i]);
            }
            Student[] foundByName = LambdaLINQ.FindByName(testStudents);
            Console.WriteLine("\n\t Students with first names before their last name alphabetically:");
            for (int i = 0; i < foundByName.Length; i++)
            {
                Console.WriteLine(foundByName[i]);
            }
            Student[] foundByAge = LambdaLINQ.FindByAge(testStudents);
            Console.WriteLine("\n\t Students in age range 18-24:");
            for (int i = 0; i < foundByAge.Length; i++)
            {
                Console.WriteLine(foundByAge[i]);
            }
            Student[] sortedLambda = LambdaLINQ.SortLambda(testStudents);
            Console.WriteLine("\n\t Sorted students in descending order by first name and then last name with Lambda:");
            for (int i = 0; i < sortedLambda.Length; i++)
            {
                Console.WriteLine(sortedLambda[i]);
            }
            Student[] sortedLINQ = LambdaLINQ.SortLinq(testStudents);
            Console.WriteLine("\n\t Sorted students in descending order by first name and then last name with LINQ:");
            for (int i = 0; i < sortedLINQ.Length; i++)
            {
                Console.WriteLine(sortedLINQ[i]);
            }
            Console.WriteLine("\n______________ check searching int array with LINQ and Lambda (task 6) ".PadRight(80, '_'));
            int[] testNums = new int[] { 3,7,35,21,0,-3,-42};
            Console.WriteLine("numbers = {0}", string.Join(" ", testNums ));
            int[] numsDiv7and3Lambda = Divisible7and3.Div7and3Lambda(testNums);
            Console.WriteLine("numbers divisible by 7 and 3 with Lambda = {0}", string.Join(" ", numsDiv7and3Lambda));
            int[] numsDiv7and3LINQ = Divisible7and3.Div7and3Linq(testNums);
            Console.WriteLine("numbers divisible by 7 and 3 with LINQ = {0}", string.Join(" ", numsDiv7and3LINQ));
            Console.WriteLine("\n______________ check custom timer with delegate (task 7) ".PadRight(80, '_'));
            CustomTimer ct = new CustomTimer(2, 2,  delegate() { Console.WriteLine("Gallileo, Gallileo"); });
            ct.ExecuteTimed();
            Console.WriteLine("Gallileo Figaro");
            Console.WriteLine("\n______________ check student class (tasks 9-15, 18, 19) ".PadRight(80, '_'));
            testStudents = new Student[] 
            {
                new Student("Freddie", "Mercury", 68 - ageAdjustment1975, "freddie@gmail.com", new List<int> {6, 6, 5}, 800406, "+359283354477", 2 ),
                new Student("Brian", "May", 67 - ageAdjustment1975, "brian.may@abv.bg", new List<int> {6, 6, 6}, 800405, "+359283358777", 2 ),
                new Student("Roger", "Taylor", 65 - ageAdjustment1975, "rtaylor@abv.bg", new List<int> {6, 5, 5}, 800303, "+359883357897", 1 ),
                new Student("John", "Deacon", 63 - ageAdjustment1975, "deaconj@abv.bg", new List<int> {2, 2, 5}, 800301, "+359883887966", 2 ),
                new Student("Mike", "Grose", 60 - ageAdjustment1975, "mike.grose@gmail.com", new List<int> {5, 5, 5}, 800398, "+359283381221", 1 ),
                new Student("Barry", "Mitchell", 68 - ageAdjustment1975, "barrym@mail.bg", new List<int> {4, 5, 5}, 800406, "+359883311256", 1 ),
                new Student("Doug", "Bogie", 60 - ageAdjustment1975, "bogie@abv.bg", new List<int> {5, 6, 5}, 800398, "+359883332665", 2 )
            };
            Console.WriteLine("\n\t Students:");
            for (int i = 0; i < testStudents.Length; i++)
            {
                Console.WriteLine(testStudents[i].ToStringExt());
            }
            Student[] selectedStudents = (from s in testStudents
                                          where s.GroupNumber == 2
                                          orderby s.FirstName.ToLower()
                                          select s).ToArray();
            Console.WriteLine("\n\t Selected students from group 2, sorted by first name:");
            for (int i = 0; i < selectedStudents.Length; i++)
            {
                Console.WriteLine(selectedStudents[i].ToStringExt());
            }
            selectedStudents = testStudents.Where(s => s.GroupNumber == 2)
                                           .OrderBy(s => s.FirstName.ToLower())
                                           .ToArray();
            selectedStudents = (from s in testStudents
                                where s.Email.Split('@')[1].ToLower() == "abv.bg"
                                select s).ToArray();
            Console.WriteLine("\n\t Selected students with email in abv.bg:");
            for (int i = 0; i < selectedStudents.Length; i++)
            {
                Console.WriteLine(selectedStudents[i].ToStringExt());
            }
            selectedStudents = (from s in testStudents
                                where (s.Tel.Substring(0, 5) == "+3592" || s.Tel.Substring(0, 2) == "02") 
                                select s).ToArray();
            Console.WriteLine("\n\t Selected students with phones in Sofia:");
            for (int i = 0; i < selectedStudents.Length; i++)
            {
                Console.WriteLine(selectedStudents[i].ToStringExt());
            }
            selectedStudents = (from s in testStudents
                                where (s.Marks.Any(m => m == 6))
                                select s).ToArray();
            Console.WriteLine("\n\t Selected students with at least one mark 6:");
            for (int i = 0; i < selectedStudents.Length; i++)
            {
                  
                Console.WriteLine(selectedStudents[i].ToStringExt());
            }
            var excellentStudents = new
            {
                fullName = (from s in selectedStudents
                            select (s.FirstName + " " + s.LastName)).ToArray(),
                marks = (from s in selectedStudents
                         select (s.Marks))
                         .ToArray()
            };
            selectedStudents = testStudents.Where(s => s.Marks.Where(m => m == 2).Count() == 2)
                                           .ToArray();
            Console.WriteLine("\n\t Selected students with exactly two marks 2:");
            for (int i = 0; i < selectedStudents.Length; i++)
            {
                Console.WriteLine(selectedStudents[i].ToStringExt());
            }
            int[] marks = testStudents.Where(s => s.FN.ToString()[4] == '0' && s.FN.ToString()[5] == '6')
                                      .Select(s => s.Marks.Select(m => m).ToArray())
                                      .SelectMany(x => x)
                                      .ToArray();
            Console.WriteLine("\n\t Marks of students who enrolled in 2006:");
            Console.WriteLine(string.Join(" ", marks));

            var groupedStudents = from s in testStudents
                                  group s by s.GroupNumber;
            Console.WriteLine("\n\t Students separated by group number with LINQ:");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group {0}:", group.First().GroupNumber);
                foreach (var student in group)
                {
                    Console.WriteLine(student.ToStringExt());
                }
            }
            groupedStudents = testStudents.GroupBy(s => s.GroupNumber);
            Console.WriteLine("\n\t Students separated by group number with extension methods:");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group {0}:", group.First().GroupNumber);
                foreach (var student in group)
                {
                    Console.WriteLine(student.ToStringExt());
                }
            }

        }
    }
}
