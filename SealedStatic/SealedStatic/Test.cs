using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedStatic
{
    internal class Test
    {
        public int Age { get; set; }
        static Test()
        {
            Console.WriteLine("Static ctor");
        }
        public Test()
        {
            Random(3);
            Console.WriteLine("Non-static ctor");
        }
        public static int Random()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
        private static int Random(int minValue)
        {
            Random rnd = new Random();
            return rnd.Next(minValue);
        }
        public static int Random(int minValue, int maxValue)
        {
            Random rnd = new Random();
            return rnd.Next(minValue, maxValue);
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
