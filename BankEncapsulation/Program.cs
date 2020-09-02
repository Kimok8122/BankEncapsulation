using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //In the main method of your application, create a new instance of
            //the BankAccount class.  Allow the user of the application to
            //Deposit money and retrieve their balance through the console.

            var yourAccount = new BankAccount();

            yourAccount.Deposit();

            yourAccount.GetBalance();

        }
    }
}
