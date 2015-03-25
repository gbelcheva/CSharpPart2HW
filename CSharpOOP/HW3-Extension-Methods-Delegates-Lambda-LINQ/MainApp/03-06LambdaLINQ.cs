namespace MainApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LambdaLINQ
    {
        public static Student[] FindByName(Student[] students)
        {
            return (from s in students
                    where (s.FirstName.ToLower().CompareTo(s.LastName.ToLower()) < 0)
                    select s).ToArray();
            //return students.Where(s => s.FirstName.ToLower().CompareTo(s.LastName.ToLower()) < 0).ToArray();
        }
        public static Student[] FindByAge(Student[] students) 
        {
            return (from s in students
                    where (18 <= s.Age && s.Age <= 24)
                    select s).ToArray();
            //retrurn students.Where(s => 18 <= s.Age && s.Age <= 24).ToArray();
        }
        public static Student[] SortLambda(Student[] students)
        {
            return students.OrderByDescending(s => s.FirstName)
                           .ThenByDescending(s => s.LastName)
                           .ToArray();
        }
        public static Student[] SortLinq(Student[] students)
        {
            return (from s in students
                    orderby s.FirstName descending, s.LastName descending
                    select s).ToArray();
        }

    }

    public class Divisible7and3
    {
        public static int[] Div7and3Lambda(int[] nums)
        {
            return nums.Where(n => n % 3 == 0 && n % 7 == 0).ToArray();
        }
        public static int[] Div7and3Linq(int[] nums)
        {
            return (from n in nums
                    where n % 7 == 0 && n % 3 == 0
                    select n).ToArray();
        }
    }

}
