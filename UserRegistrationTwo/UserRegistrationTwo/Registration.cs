using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTwo
{
    public class Registration
    {
        public bool First(string input_firstname)
        {
            string pattern_name = @"^[A-Z][a-z]{2,}";

            Regex obj = new Regex(pattern_name);
            return true;
        }
        public bool Last(string input_lastname)
        {
            string pattern_name = @"^[A-Z][a-z]{2,}";

            Regex obj = new Regex(pattern_name);
            return true;
        }

        public bool Email(string input_email)
        {
            string pattern_email = @"^[A-Za-z.-_]{3,}[@][A-Za-z]{2,}[.][A-Za-z]{2,3}[.]{0,1}[A-Za-z]{0,2}$"; //abc.xyz@bl.co.in
            
            Regex obj = new Regex(pattern_email);
            return true;
        }

        public bool Mobile(string input_mobile)
        {
            string pattern_mobile = @"^[9][1][ ][6-9][0-9]{9}$";

            Regex obj = new Regex(pattern_mobile);
            return true;
        }

        public bool Password(string input_password)
        {
            string pattern_password = @"^[A-Z][0-9][A-Za-z0-9.-_]{5,}[@.-_]$";
            
            Regex obj = new Regex(pattern_password);
            return true;
        }

    }
}
