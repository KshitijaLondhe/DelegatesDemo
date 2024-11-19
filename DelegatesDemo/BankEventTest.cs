using System;

namespace DelegatesDemo
{
    public delegate void GetMessage();
    public class BankEventTest
    {

        public static void InsufficientBalanceMsg()
        {
            Console.WriteLine("Your Current Balance is Insufficient to Withdraw Amount");
        }
        public static void LowBalanceMsg()
        {
            Console.WriteLine("Your Current Balance is Low");
        }
        public static void ZeroBalanceMsg()
        {
            Console.WriteLine("Your Current Balance is Zero");
        }
        static void Main(string[] args)
        {
            Bank bk = new Bank();
            

            bk.InsufficientBalance += new GetMessage(InsufficientBalanceMsg);
            bk.LowBalance += new GetMessage(LowBalanceMsg);
            bk.ZeroBalance += new GetMessage(ZeroBalanceMsg);

            bk.Credit(500);
            bk.Debit(200);
        }
    }
}
