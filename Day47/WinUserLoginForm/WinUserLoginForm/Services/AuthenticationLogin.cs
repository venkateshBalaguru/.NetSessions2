using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUserLoginForm.Services
{
    public class AuthenticationLogin
    {
        private Dictionary<string, string> userDetails = new Dictionary<string, string>()
        {
            {"Venkat","Pass1" },
            {"Sachin","Pass2" },
            {"Akhil","Pass3" }
        };

        public bool IsValid(string username, string password)
        {
         if (userDetails.ContainsKey(username) && userDetails[username] == password)
          {
            return true;
          }
            return false;
        }   
    }

    
}
