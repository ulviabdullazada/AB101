using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedStatic
{
    sealed class FullStackDeveloper:Developer
    {
        public int SkillLevel { get; set; }
        //public override void PrintInfo()
        //{
        //    Console.WriteLine("Salam");
        //}
    }
}
