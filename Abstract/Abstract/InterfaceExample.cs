using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //abstract class Calculate
    //{
    //    public abstract int Sum(int a, int b);
    //    public abstract int Difference(int a, int b);
    //    public abstract float Divide(int a, int b);
    //    public abstract int Multiply(int a, int b);
    //}
    interface ITest
    {
        void SayHi()
        {
            Console.WriteLine("Salam");
        }
    }
    class Test : ITest
    {

    }
    interface ISum
    {
        int Sum(int a, int b);
    }
    interface IDivide
    {
        float Divide(int a, int b);
    }
    interface IDiff
    {
        int Difference(int a, int b);
    }
    interface IMultiply
    {
        int Multiply(int a, int b);
    }
    class MarketCalculation : ISum, IMultiply, IDiff
    {
        public int Difference(int a, int b)
            => a - b;

        public int Multiply(int a, int b)
            => a * b;

        public int Sum(int a, int b)
            => a + b;
    }
}
