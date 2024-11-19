using System;
using System.Collections.Generic;


namespace DelegatesDemo
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            //code for single cast delegate
            /*CalculatorSCD c1 = new CalculatorSCD();
            CalDelegate cd = new CalDelegate(c1.Add);
            int res = cd.Invoke(10, 20);
            Console.WriteLine("Addition :"+res);

            User u = new User();
            NameDelegate nm = new NameDelegate(u.AddName);
            Console.WriteLine(nm.Invoke("kshitija"));
            */
            //code for multi cast delegate
           /* CalculatorMCD c2 = new CalculatorMCD();
            CalciDelegate obj = new CalciDelegate(c2.Add);
            int result = obj.Invoke(10, 20);
            Console.WriteLine("Addition :"+result);
            obj += new CalciDelegate(c2.Sub);
            obj += new CalciDelegate(c2.Multiply);
            //obj -= new CalciDelegate(c2.Sub); 
            // -= will remove method from invocation list

            // Delegate will create the invocationList 
            // invocationList hold methods refer in the same sequence that we have added
            // basic need of multicast delegate is --> to invoke methods in a sequence.

            Delegate[] list = obj.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(10,20));
            }

        }*/
    }
}
