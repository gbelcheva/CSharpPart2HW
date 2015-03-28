namespace _03Test
{
    using System;
    public abstract class Animal : ISound
    {
        private int age;
        private Sexes sex;
        public enum Sexes
        {
            male,
            female
        }
        
        public string Name { get; private set; }
        public Sexes Sex { 
            get 
            { 
                return sex; 
            }
            private set 
            {
                this.sex = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || 150 < value)
                {
                    throw new ArgumentOutOfRangeException("Age should be in the range [0,150]");
                }
                this.age = value;
            }
        }
        public Animal(string name, int age, Sexes animalSex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = animalSex;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Sex;
        }
        public virtual void MakeSound()
        {
            Console.Write("The {0} {1} ", this.GetType().Name.ToLower(), this.Name);
        }
    }
}
