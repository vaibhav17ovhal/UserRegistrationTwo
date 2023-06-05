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
                try
                {
                    if (obj.IsMatch(input_name))
                    {
                        Console.WriteLine($"'{input_name}' is a valid User Name.\n");
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

                Console.Write("Please enter last name: ");
                input_name = Console.ReadLine();
                try
                {
                    if (obj.IsMatch(input_name))
                    {
                        Console.WriteLine($"'{input_name}' is a valid last Name.\n");
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        public void EmailRegistration()
        {
            string pattern_email = @"^[A-Za-z.-_]{3,}[@][A-Za-z]{2,}[.][A-Za-z]{2,3}[.]{0,1}[A-Za-z]{0,2}$"; //abc.xyz@bl.co.in
            string input_email = "";

            Regex obj = new Regex(pattern_email);

            while (true)
            {
                Console.Write("Enter your email: ");
                input_email = Console.ReadLine();
                try
                {
                    if (obj.IsMatch(input_email))
                    {
                        Console.WriteLine($"'{input_email}' is a valid Email.\n");
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

               
            }
        }
        public void MobileRegistration()
        {
            string pattern_mobile = @"^[9][1][ ][6-9][0-9]{9}$"; //91 9340596362
            string input_mobile = "";

            Regex obj = new Regex(pattern_mobile);

            while (true)
            {
                Console.Write("Enter your mobile number: ");
                input_mobile = Console.ReadLine();
                try
                {
                    if (obj.IsMatch(input_mobile))
                    {
                        Console.WriteLine($"'{input_mobile}' is a valid mobile number.\n");
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        public void PasswordRegistration()
        {
            //string pattern_password_rule1 = @"^[A-Za-z0-9.-_]{8,}$";
            //string pattern_password_rule2 = @"^[A-Z][A-Za-z0-9.-_]{7,}$";
            //string pattern_password_rule3 = @"^[A-Z][0-9][A-Za-z0-9.-_]{6,}$";
            string pattern_password_rule4 = @"^[A-Z][0-9][A-Za-z0-9.-_]{5,}[@.-_]$";
            string input_password_rule4 = "";

            Regex obj = new Regex(pattern_password_rule4);

            while (true)
            {
                Console.Write("Enter the password: ");
                input_password_rule4 = Console.ReadLine();
                try
                {
                    if (obj.IsMatch(input_password_rule4))
                    {
                        Console.WriteLine($"'{input_password_rule4}' is a valid password.\n");
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message); 
                }
                
            }
        }
        public void CheckEmail(string input_mail)
        {
            string pattern_mail = @"[A-Za-z0-9._+-]{3}[@][A-Za-z0-9]{1,}[.][a-z]{3}[.]{0,1}[a-z]{0,}$";

            Regex obj2 = new Regex(pattern_mail);

            while (true)
            {
                try
                {
                    if (obj2.IsMatch(input_mail))
                    {
                        Console.WriteLine($"'{input_mail}' is a valid Email.\n");
                        break;
                    }
                    else
                    {
                        throw new Exception("Invailid Input!! \nTry Again...\n");
                    }
                }
                catch( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        public int Adding(int num1 , int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

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

        public bool Checking(string input_emailID)
        {
            string pattern_mailID = @"[A-Za-z0-9._+-]{3}[@][A-Za-z0-9]{1,}[.][a-z]{3}[.]{0,1}[a-z]{0,}$";
            
            Regex obj = new Regex(pattern_mailID);
            return true;
        }

    }
}
