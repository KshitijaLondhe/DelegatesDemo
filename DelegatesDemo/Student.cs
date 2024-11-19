using System;



namespace DelegatesDemo
{
    public class Student
    {
        // events
        // Pass,Fail :event names
        public event DisplayMessage Pass;
        public event DisplayMessage Fail;

        public void AcceptPercentage(int per)
        {
            if (per >= 35)
            {
                Pass();  
            }
            else
            {
                Fail();
            }
        }
        
    }
}
