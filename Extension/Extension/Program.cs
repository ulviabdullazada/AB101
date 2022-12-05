using Extension.Models;
using Extension.Utilies.Helpers;
using System.Text;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string password = "";
            do
            {
                name = Console.ReadLine();
                password = Console.ReadLine();
            } while (!(ValidationHelper.PasswordValidator(password) && ValidationHelper.UsernameValidator(name)));
            User u = new User
            {
                Name = name,
                Password = password
            };
            Console.WriteLine("OK");
        }
    }
}