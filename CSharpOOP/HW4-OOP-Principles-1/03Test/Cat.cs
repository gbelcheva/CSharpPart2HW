namespace _03Test
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sexes sex) 
            : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("meows.");
        }
    }
}
