using Extension.Utilies.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Models
{
    internal class User
    {
		private string _name;
		private string _password;
		public string Name
        {
			get { return _name; }
			set
			{
				if (ValidationHelper.UsernameValidator(value))
				{
					_name = value;
				}
			}

		}
		public string Password
        {
			get { return _password; }
			set 
			{
				if (ValidationHelper.PasswordValidator(value))
				{
					_password = value;
				}
			}
		}
		
    }
}
