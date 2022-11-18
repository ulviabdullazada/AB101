using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Student:Person //inheritance
    {
        //fields
        public int Course;
        public string Group;

        //properties

        //constuctor - class-dan instance alinan zaman ishe dushen ilk methoddur, mutleq class adi ile eyni olmalidir.
        public Student() //parameterless
        {
        }
        public Student(string Name) : base(Name)
        {
        }
        public Student(string Name, string Surname) : base(Name, Surname)
        {
        }
        public Student(string Name, string Surname, int Age) : base(Name, Surname, Age)
        {
        }
        public Student(string Name, string Surname, int Age, int Course) : base(Name, Surname, Age)
        {
            this.Course = Course;
        }

        //methods

        public string GetFullInfo()
        {
            return $"{Name} {Surname} {Age} {Group}";
        }
        //indexer
    }
}
