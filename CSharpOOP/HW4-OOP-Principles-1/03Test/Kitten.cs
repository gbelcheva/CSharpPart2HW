namespace _03Test
{
    using System;
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Sexes sex = Sexes.female)
            : base(name, age, sex)
        {
        }
    }
}
