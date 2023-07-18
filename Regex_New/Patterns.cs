using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_New
{
    class Patterns
    {
        public static string Regex_FName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_LName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, Regex_FName);
        }
        public bool ValidateLName(string LName)
        {
            return Regex.IsMatch(LName, Regex_LName);
        }
    }
}
