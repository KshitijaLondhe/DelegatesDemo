using System;


namespace DelegatesDemo
{
    public delegate void DisplayMessage();
    public class StudentEventTest
    {
        public static void PassMsg()
        {
            Console.WriteLine("Congratulations!!You Are Pass");
        }
        public static void FailMsg()
        {
            Console.WriteLine("Sorry!!You Are Fail");
        }

      /* static void Main(string[] args)
        {
            Student s = new Student();
            // bind event with delegate / configuration
            //s.Pass += new DisplayMessage(PassMsg);
            //s.Fail += new DisplayMessage(FailMsg);

            s.AcceptPercentage(86);

        }*/
    }
}
