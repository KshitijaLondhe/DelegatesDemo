using System;
using System.Collections.Generic;


namespace DelegatesDemo
{
    public delegate int CalciDelegate(int a, int b);
    public class CalculatorMCD
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
