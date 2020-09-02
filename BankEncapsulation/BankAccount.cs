using System;
namespace BankEncapsulation
{
    //Create a new Console Application in your repos folder
    //name it BankEncapsulation

    //Create a new public class named BankAccount

    public class BankAccount
    {
        
        public BankAccount()
        {

        }

     //A private field of type double named balance with a value of 0

        private double balance = 0;

     //Define a method named Deposit that will accept a double and store that
     // value in the balance field

        public void Deposit()
        {
            Console.WriteLine($"Enter amount of your deposit: $ ");
            var depositAmount = double.Parse(Console.ReadLine());
            balance = depositAmount;
        }

        // Define a method named GetBalance that will return
        //the amount stored in the balance field

        public double GetBalance()
        {
            Console.WriteLine($" ${balance} has been deposited.");
            return balance;
            
        }

    }
}
  