public class People
{
    private enum Genders
    {
        male, 
        female
    }

    public void MakePerson(int age)
    {
        Person personInstance = new Person();

        personInstance.Age = age;
        if (age % 2 == 0)
        {
            personInstance.Name = "John";
            personInstance.Gender = Genders.male;
        }
        else
        {
            personInstance.Name = "Jane";
            personInstance.Gender = Genders.female;
        }
    }

    public class Person
    {
        public Genders Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}