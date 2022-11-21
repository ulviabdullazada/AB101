using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = Console.ReadLine(),
                Surname = Console.ReadLine(),
                Age = Convert.ToByte(Console.ReadLine())
            };
            //student.Surname
            //student.Get
            Console.WriteLine($"Name: {student.Name} \nSurname: {student.Surname}\nAge: {student.Age}");
        }
    }
}