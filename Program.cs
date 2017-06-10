using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string name;
        public DateTime birthDate;
        public enum Genders { male, female };

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "name: " + name + "\n" +
                   "date of birth: " + birthDate;
        }
    }

    class Employee : Person
    {
        public int salary;
        public string profession;

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return "name: " + name + "\n" +
                   "birthDate: " + birthDate + "\n" +
                   "salary: " + salary + "\n" +
                   "profession: " + profession;
        }
    }

    class Room : Employee
    {
        public int Number;

        public Room(string name, DateTime birthDate, int salary, string profession, int Number) : base(name, birthDate, salary, profession)
        {
            this.Number = Number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Hát = new Employee("Izsák", DateTime.Now, 2000, "Sewer");
            Console.WriteLine(Hát);
            Console.ReadKey();
        }
    }
}
