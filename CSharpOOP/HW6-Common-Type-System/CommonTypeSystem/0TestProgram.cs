using System;

namespace CommonTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student testStudent1 = new Student("Werner", "Karl", "Heisenberg", 88462311, 4, Student.Specialties.Physics, Student.Faculties.Physics, Student.Universities.UniversityOfMunich);
            Student copyStudent1 = new Student("Werner", "Karl", "Heisenberg", 88462311, 4, Student.Specialties.Physics, Student.Faculties.Physics, Student.Universities.UniversityOfMunich);
            Student testStudent2 = new Student("Werner", "Karl", "Heisenberg", 78462311, 4, Student.Specialties.Physics, Student.Faculties.Physics, Student.Universities.UniversityOfMunich);

            Console.WriteLine("\n____________ Students ".PadRight(100, '_'));
            Console.WriteLine("                s1: {0}", testStudent1);
            Console.WriteLine("New instance of s1: {0}", copyStudent1);
            Console.WriteLine("                s2: {0}", testStudent2);

            Console.WriteLine("\n____________ Check hash code ".PadRight(100, '_'));
            Console.WriteLine("                s1: hash code {0}",  testStudent1.GetHashCode());
            Console.WriteLine("New instance of s1: hash code {0}",  copyStudent1.GetHashCode());
            Console.WriteLine("                s2: hash code {0}",  testStudent2.GetHashCode());

            Console.WriteLine("\n____________ Check SSN ".PadRight(100, '_'));
            Console.WriteLine("                s1: SSN {0}", testStudent1.SSN);
            Console.WriteLine("New instance of s1: SSN {0}", copyStudent1.SSN);
            Console.WriteLine("                s2: SSN {0}", testStudent2.SSN);

            Console.WriteLine("\n____________ Compare s1 and s2 (s1 < s2) ".PadRight(100, '_'));
            Console.WriteLine(testStudent1.CompareTo(testStudent2) < 0);

            Console.WriteLine("\n____________ Check Person ".PadRight(100, '_'));
            Person p1 = new Person("Vladko Vladkovski", null);
            Person p2 = new Person("Sashko Sashkovski", 20);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("\n____________ Check BitArray64(ulong) ".PadRight(100, '_'));
            BitArray64 bitArr = new BitArray64(6UL);
            Console.WriteLine("BitArray({0}) = {1}", bitArr.Number, string.Join("", bitArr));
            Console.WriteLine("Set bit at position 0 to 1");
            bitArr[0] = 1;
            Console.WriteLine("BitArray({0}) = {1}", bitArr.Number, string.Join("", bitArr));
            int index1 = 2;
            int index2 = 4;
            Console.WriteLine("Take bits at position {0} and {1}", index1, index2);
            Console.WriteLine("BitArray({0})[{1}] = {3}\nBitArray({0})[{2}] = {4}", bitArr.Number, index1, index2, bitArr[index1], bitArr[index2]);


        }
    }
}
