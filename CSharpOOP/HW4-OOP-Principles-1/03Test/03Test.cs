namespace _03Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class _03Test
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>() 
            {
                new Tomcat("Tom", 10),
                new Kitten("Angela", 8),
                new Frog("Kermit", 5, Animal.Sexes.male),
                new Dog("Scooby-Doo", 6, Animal.Sexes.male),
                new Dog("Gooby", 2, Animal.Sexes.male),
                new Cat("Annabelle", 5, Animal.Sexes.female)
            };
            Console.WriteLine("\n____________ Animals ".PadRight(100, '_'));
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n____________ Test animal sound ".PadRight(100, '_'));
            foreach (var a in animals)
            {
                a.MakeSound();
            }
            Cat[] cats = new Cat[]
            {
                new Cat("Eek", 6, Animal.Sexes.male),
                new Cat("Annabelle", 5, Animal.Sexes.female),
                new Cat("Angela", 8, Animal.Sexes.female),
                new Cat("Tom", 12, Animal.Sexes.male)
            };
            Console.WriteLine("\n____________ Cats ".PadRight(100, '_'));
            foreach (var c in cats)
            {
                Console.WriteLine(c);
            }
            Dog[] dogs = new Dog[]
            {
                new Dog("Scooby-Doo", 6, Animal.Sexes.male),
                new Dog("Gooby", 2, Animal.Sexes.male),
                new Dog("Droopy", 16, Animal.Sexes.male),
                new Dog("Pluto", 17, Animal.Sexes.male)
            };
            Console.WriteLine("\n____________ Dogs ".PadRight(100, '_'));
            foreach (var d in dogs)
            {
                Console.WriteLine(d);
            }
            Frog[] frogs = new Frog[]
            {
                new Frog("Kermit", 5, Animal.Sexes.male),
                new Frog("JabbaTheFrog", 11, Animal.Sexes.male)
            };
            Console.WriteLine("\n____________ Frogs ".PadRight(100, '_'));
            foreach (var f in frogs)
            {
                Console.WriteLine(f);
            }

            Dictionary<string, double> animalAvgAge = new Dictionary<string, double>();
            animalAvgAge.Add(cats[0].GetType().Name, cats.Select(c => c.Age).Average());
            animalAvgAge.Add(dogs[0].GetType().Name, dogs.Select(d => d.Age).Average());
            animalAvgAge.Add(frogs[0].GetType().Name, frogs.Select(f => f.Age).Average());

            Console.WriteLine("\n____________ Average ages ".PadRight(100, '_'));
            foreach (var age in animalAvgAge)
            {
                Console.WriteLine(age.Key + "s average age is " + age.Value + " years.");
            }

        }
    }
}
