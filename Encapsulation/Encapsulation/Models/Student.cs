using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Student
    {
        string _name;
        string _surname;
        byte _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                if (value.Trim().Length<16)
                {
                    _name = value.Trim();
                }
            }
        }
        
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length < 20 && value.EndsWith("li"))
                {
                    _surname = value;
                }
                else
                {
                    int a = DateTime.Now.Year;
                    _surname = "XXX";
                }
            }
        }

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 160)
                {
                    _age = value;
                }
            }
        }
        //public void SetName(string value)
        //{
        //    if (value.Trim().Length < 15)
        //    {
        //        _name = value.Trim();
        //    }
        //}
        //public string GetName()
        //{
        //    return _name;
        //}
    }
}
