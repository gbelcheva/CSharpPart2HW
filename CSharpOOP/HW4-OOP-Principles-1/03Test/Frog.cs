namespace _03Test
{
    using System;
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sexes sex)
            : base(name, age, sex)
        {

        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("croaks.");
        }
    }
}
