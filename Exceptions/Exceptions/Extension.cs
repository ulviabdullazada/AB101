using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class Extension
    {
        public static int Parse(this string str)
        {
            try
            {
                int num = 0;
                int n = str.Length;

                // Iterate till length of the string 
                for (int i = 0; i < n; i++)
                    num = num * 10 + ((int)str[i] - 48);
                if (num.ToString() == str)
                {
                    return num;
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
