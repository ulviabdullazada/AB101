using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Group
    {
        readonly int _privProp;
        public string Name { get; set; }
        public Student[] Students { get; set; }
        public Group()
        {
            _privProp = 100;
        }
        public void PrintPriv()
        {
            Console.WriteLine(_privProp);
        }
        public bool HasStudent(string id)
        {
            foreach (Student item in Students)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            StudentNotFoundException ex = new StudentNotFoundException("Salam");
            throw ex;
        }
    }
}
