using System;

/*Assessment on Event & Delegate
Create a Bank a class, with Debit & Credit method
You can assign a default balance using constructor
Credit method will accept the amount that needs to be added in balance
Debit method will accept the amount that needs to be deducted from the balance.
If amount is greater than balance raise an event → insufficient balance
If balance is low (< 3000) raise an event low balance
If balance is zero then raise an event zero balance.
*/
namespace DelegatesDemo
{
    public class Bank
    {
        public event GetMessage InsufficientBalance;
        public event GetMessage LowBalance;
        public event GetMessage ZeroBalance;

        private double balance;
        public Bank()
        {
            balance=1000;
        }
        public void Debit(double amount)
        {
            if (balance == 0)
            {
                ZeroBalance();
            }
            else if (amount > balance)
            {
                InsufficientBalance();
            }
            else if (balance < 3000)
            {
                LowBalance();
            }

            else
            {
                balance = balance - amount;
                Console.WriteLine("Amount Debited "+amount+"Balance:"+balance);
            }

        }

        public void Credit(double amount)
        {
            
            if (balance == 0)
            {
                ZeroBalance();
            }
            else if (balance < 3000)
            {
                LowBalance();
            }
            else
                balance = balance + amount;
        }
    }
}
