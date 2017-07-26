using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            new Person().SetDesignation("HR");
            // new Person().SetDesignation(null);

            new Person().SetDepartment("HR");
            // new Person().SetDepartment(null);

            //new Person().SetSalary(1000.0);
        }
    }

    public class Person
    {
        private string m_designation;
        private string m_department;

        public void SetDesignation(string designation)
        {
            m_designation = designation ?? throw new ArgumentNullException(designation);
        }

        public void SetDepartment(string department)
        {
            m_department = department == null ? throw new ArgumentNullException(department) : department;
        }

        public void SetSalary(double salary) => throw new NotImplementedException();
    }
}
