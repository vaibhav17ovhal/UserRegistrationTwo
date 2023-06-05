using System;

namespace UserRegistrationTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");

            Console.WriteLine("\n==============||===============\n");

            Registration reg = new Registration();
            //reg.Register();
            //reg.EmailRegistration();
            //reg.MobileRegistration();
            reg.PasswordRegistration();
            /*reg.CheckEmail("abc@yahoo.com");
            reg.CheckEmail("abc-100@yahoo.com");
            reg.CheckEmail("abc.100@yahoo.com");
            reg.CheckEmail("abc111@abc.com");
            reg.CheckEmail("abc-100@abc.net");
            reg.CheckEmail("abc.100@abc.com.au");
            reg.CheckEmail("abc@1.com");
            reg.CheckEmail("abc@gmail.com.com");
            reg.CheckEmail("abc+100@gmail.com");*/
        }
    }
}
