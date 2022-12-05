using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedStatic
{
    abstract class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {
            _id++;
            Id = _id;
        }
        public abstract void PrintInfo();
    }
}
