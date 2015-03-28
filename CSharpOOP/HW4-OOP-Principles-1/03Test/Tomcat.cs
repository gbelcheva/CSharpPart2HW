namespace _03Test
{
    using System;
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Sexes sex = Sexes.male)
            : base(name, age, sex)
        {
        }
    }
}
