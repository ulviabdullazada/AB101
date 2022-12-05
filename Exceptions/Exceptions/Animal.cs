using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();
        public virtual void Grow()
        {
            Console.WriteLine("Grew");
        }
    }
    abstract class Bird : Animal
    {
        //public abstract void Fly();
        public virtual void Fly()
        {
            Console.WriteLine("Fly as Bird");
        }
    }
    class Parrot : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Parrot");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Parrot");
        }

        public void Talk()
        {
            Console.WriteLine("Cici kush");
        }
        public override void Grow()
        {
            base.Grow();
        }
    }
    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }
    }
    class Duck : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Duck");
        }

        public void Swim()
        {
            Console.WriteLine("Swim as Duck");
        }
    }
    class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Penguin");
        }
        public override void Fly()
        {
            Console.WriteLine("Sorry penguin cannot fly");
        }
    }
    abstract class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }
        public override void Grow()
        {
            Console.WriteLine("Grew as Shark");
        }
    }
    
}
