using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAplication
{
    public class Worker
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Dept
    {
        public string DName { get; set; }
        public double Salary { get; set; }

        public List<Worker> Workers = new List<Worker>();
    }

    class Test
    {


        public static void Main(String[] args)
        {
            List<Dept> department = new List<Dept>()
            {
                new Dept {DName ="HR",Salary =50000,Workers = {
                        new Worker{Id=1,Name="Ajay",City="Pcmc"},
                         new Worker{Id=2,Name="Aniket",City="Pune"},
                    }
                },
                 new Dept {DName ="Finance",Salary =40000,Workers = {
                        new Worker{Id=1,Name="Kiran",City="Nashik"},
                         new Worker{Id=2,Name="Ankit",City="Pcmc"},
                    }
                },
            };
            foreach (Dept d in department)
            {
                Console.WriteLine("\n" + d.DName);
                foreach (Worker w in d.Workers)
                {
                    Console.WriteLine($"{w.Id}{w.Name}{w.City}");
                }
            }
        }
    }
}
