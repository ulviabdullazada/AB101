using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedStatic
{
    class Developer:Person
    {
        public float Salary { get; set; }
        public sealed override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Salary}");
        }
    }
}
