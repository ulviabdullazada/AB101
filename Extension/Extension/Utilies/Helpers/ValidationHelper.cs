using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Utilies.Helpers
{
    class ValidationHelper
    {
        public static bool UsernameValidator(string str)
        {
            foreach (char item in str)
            {
                if (!Char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool PasswordValidator(string str)
        {
            if (IsPasswordValid(str) && HasUpper(str) && HasDigit(str) && HasLower(str) && str.Length > 7) return true;
            return false;
        }
        static bool IsPasswordValid(string str)
        {
            foreach (char item in str)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HasUpper(string str)
        {
            foreach (char item in str)
            {
                if (Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }
        static bool HasLower(string str)
        {
            foreach (char item in str)
            {
                if (Char.IsLower(item))
                {
                    return true;
                }
            }
            return false;
        }
        static bool HasDigit(string str)
        {
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
