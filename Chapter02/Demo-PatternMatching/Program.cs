using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Employee { Firstname = "Kunal" };
            Person p2 = new Customer { Firstname = "Manika", IsPremium = true };
            Person p3 = new Person { Firstname = "Dwijen" };

            //CheckOldWays(p1);
            //CheckNewWays(p2);

            //CheckAndDisplay(50);

            // satisfies the first case of type Employee
            Validate(new Employee { Firstname = "Kunal" });

            // satisfies the second case where the person is a Premium Customer
            Validate(new Customer { Firstname = "Kunal", IsPremium = true });

            // satisfies the third case where the person is a Normal Customer
            Validate(new Customer { Firstname = "Kunal" });

            // satisfies the fourth case where the person does not fit any of the above cases
            Validate(new Person { Firstname = "Kunal" });

            // satisfies the fifth case when the person object is set as 'null'
            Validate(null);
        }

        #region Is Expression
        private static void CheckAndDisplay(object obj)
        {
            if(!(obj is int i)) { return; }

            Console.WriteLine("Value of i: " + i);
        }

        private static void CheckNewWays(Person person)
        {
            if (person is Employee employee)
            {
                Console.WriteLine("Person '{0}' is an Employee", employee.Firstname);
            }
            else if (person is Customer customer)
            {
                Console.WriteLine("Person '{0}' is a Customer", customer.Firstname);
            }
        }

        private static void CheckOldWays(Person person)
        {
            if (person is Employee)
            {
                Employee employee = (Employee)person;
                Console.WriteLine("Person '{0}' is an Employee", employee.Firstname);
            }
            else if (person is Customer)
            {
                Customer customer = (Customer)person;
                Console.WriteLine("Person '{0}' is a Customer", customer.Firstname);
            }
        }
        #endregion Is Expression

        #region Switch Expression
        public static void Validate(Person person)
        {
            switch (person)
            {
                case Employee e:
                    Console.WriteLine($"{e.Firstname} is an Employee");
                    break;

                case Customer c when (c.IsPremium):
                    Console.WriteLine($"{c.Firstname} is a Premium Customer");
                    break;

                case Customer c:
                    Console.WriteLine($"{c.Firstname} is a Customer");
                    break;

                default:
                    Console.WriteLine($"{person.Firstname} is a Person");
                    break;

                case null:
                    Console.WriteLine("Null value specified\n");
                    break;
            }
        }
        #endregion Switch Expression
    }
}
