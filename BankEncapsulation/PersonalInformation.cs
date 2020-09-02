using System;
using System.Text.RegularExpressions;

namespace BankEncapsulation
{
    public class PersonalInformation
    {
        public PersonalInformation()
        {
        }

         public string FristName { get; set; }
         public string LastName { get; set; }
         public string StreetAddress { get; set; }
         public string Address2 { get; set; }
         public string City { get; set; }
         public string State { get; set; }
         public int Zip { get; set; }

         private string phoneNumber;
         
         public string Numberformatted
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }


            public void KeyedInfomation()

            {
            Console.WriteLine($"------------------------");
            Console.WriteLine($"What is your Frist Name: ");
            var yourName = (Console.ReadLine());
            FristName = yourName;
            Console.WriteLine($"Thanks {FristName}");

            Console.WriteLine($"------------------------");
            Console.WriteLine($"What is your Last Name: ");
            var yourLastName = (Console.ReadLine());
            LastName = yourLastName;
            Console.WriteLine($"Thanks {FristName} {LastName}");

            Console.WriteLine($"------------------------");
            Console.WriteLine($"What is your Zipcode: ");
            int yourZipcode = int.Parse(Console.ReadLine());
            Zip = yourZipcode;
            Console.WriteLine($"Zipcode: {Zip}");

            Console.WriteLine($"------------------------");
            Console.WriteLine($"What is your phone number: ");
            var yourPhone = (Console.ReadLine());
            Numberformatted = yourPhone;
            Console.WriteLine($"Phone Number: {phoneNumber}");

            }

    





    }   
}       
        