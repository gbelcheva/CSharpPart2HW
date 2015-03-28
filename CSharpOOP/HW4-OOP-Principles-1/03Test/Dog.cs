namespace _03Test
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sexes sex)
            : base(name, age, sex)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("barks.");
        }
    }
}
