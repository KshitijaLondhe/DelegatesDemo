using System;
/*Delegates
Delegate is a reference type in C#
Delegate is used to hold a method reference
Delegate is also called as type safe pointer in C#
There are two types of delegates	
Single cast delegate  → One delegate hold one method reference
Multicast delegate  → One delegate hold multiple method references

Declaration of Delegates
Access specifier   delegate-keyword return type delegate-name(parameters…)
Method syntax & delegate syntax should be same  (syntax – return type,parameters)
*/

namespace DelegatesDemo
{
    // we will declare delegate in the namespace
    // variable name can be same or diff


    public delegate int CalDelegate(int x,int y);
    public delegate string NameDelegate(string a);
    public class CalculatorSCD
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class User
    {
        public string AddName(string name)
        {
            return name;
        }
     
    }
}
