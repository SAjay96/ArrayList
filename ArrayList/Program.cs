using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAplication
{
    public delegate int MyDelegate(int n1, int n2);
    public class Calculation
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


    class prog
    {

    
         public static void Main(String[] args)
        {
            Calculation c = new Calculation();
            // += add method ref in the invocation list
            MyDelegate mydel = new MyDelegate(c.Sub);// added method ref
            mydel += new MyDelegate(c.Add);
            mydel += new MyDelegate(c.Multiply);
            // -= can be used to remove method reference from the
            // invoction list
            mydel -= new MyDelegate(c.Sub);
            Delegate[] list = mydel.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45, 32));
            }   

        }
    }
}
