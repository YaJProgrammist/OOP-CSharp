using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearOfBirth
        {
            get
            {
                return DateOfBirth.Year;
            }

            set
            {
                DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day);
            }
        }

        public Person()
        {
            Name = "Iван";
            Surname = "Iванов";
            DateOfBirth = new DateTime(2000, 1, 1);
        }

        public Person(string N, string S, DateTime D)
        {
            Name = N;
            Surname = S;
            DateOfBirth = D;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Iм'я: " + Name);
            Console.WriteLine("Прiзвище: " + Surname);
            Console.WriteLine("Дата народження: " + DateOfBirth.ToShortDateString());
        }
    }
}
