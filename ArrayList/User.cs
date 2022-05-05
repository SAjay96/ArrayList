using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public delegate void MyDelegate(string n);

  public class User
    {
        public void Upper(string str)
        {
            string Upperstr = str.ToUpper();
            
        }
        public void Lower(string str)
        {
            string Loewerstr = str.ToLower();
        }
    }
    class program
    {
        public static void Main()
        {
            User u = new User();
            MyDelegate mydel=(u.Upper);
            mydel = (u.Lower);
            Delegate[] list = mydel.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Hello");
            }

        }
    }
}
