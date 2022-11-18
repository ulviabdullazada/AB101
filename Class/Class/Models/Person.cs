using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person() //parameterless
        {
        }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public Person(string Name, string Surname) : this(Name)
        {
            this.Surname = Surname;
        }
        public Person(string Name, string Surname, int Age) : this(Name, Surname)
        {
            this.Age = Age;
        }

        public string GetFullInfo()
        {
            return $"{Name} {Surname} {Age}";
        }
        
    }
}
