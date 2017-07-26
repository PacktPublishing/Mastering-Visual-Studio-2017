using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Kunal Chowdhury";

            Console.WriteLine("Person Name: " + person.Name);
        }
    }

    public class Person
    {
        private string m_name;

        // constructor
        public Person() => Console.WriteLine("Constructor called");

        // destructor
        ~Person() => Console.WriteLine("Destructor called\n");

        // getter/setter properties
        public string Name
        {
            get => m_name;
            set => m_name = value;
        }
    }
}
