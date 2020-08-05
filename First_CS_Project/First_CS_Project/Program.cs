using System;

namespace First_CS_Project
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void greetPerson()
        {
            Console.WriteLine(Name + " is " + Age + "  and he has a pet " + HasPet);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Name = "Omer Quadri";
            person1.Age = 23;
            person1.HasPet = true;

            person1.greetPerson();
        }
    }
}
