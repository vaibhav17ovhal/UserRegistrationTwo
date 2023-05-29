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
        public void Register()
        {
            string pattern_name = @"^[A-Z][a-z]{2,}";
            string input_name = "";

            Regex obj = new Regex(pattern_name);

            while (true)
            {
                Console.Write("Please enter first name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid User Name.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }

                Console.Write("Please enter last name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid last Name.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
    }
}
