using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  City { get; set; }
        public double  Salary { get; set; }
        public string Dept { get; set; }
    }

    class testr
    {
        public static void Main(string[] args)
        {
            List<Product> productList = new List<Product>()
         {
            new Product{Id=1,Name="HP",Price=34000},
            new Product{Id=2,Name="dell",Price=36000},
            new Product{Id=3,Name="acer",Price=35000},
            new Product{Id=4,Name="lenovo",Price=34080},
            new Product{Id=5,Name="HP",Price=39000},
            new Product{Id=6,Name="dell",Price=34500},
            new Product{Id=7,Name="HP",Price=39900},
        };
            List<Employee> empList = new List<Employee>()
            {
                new Employee{Id=1,Name="Ajay",City="Pune",Salary=45000,Dept="HR"},
                 new Employee{Id=2,Name="Aniket",City="Mumbai",Salary=55000,Dept="Sale"}, 
                new Employee{Id=3,Name="ganesh",City="Mumbai",Salary=35000,Dept="Finance"},
                 new Employee{Id=4,Name="Swapnil",City="Pune",Salary=65000,Dept="HR"},
                  new Employee{Id=5,Name="mahesh",City="Thane",Salary=25000,Dept="Admin"},
                   new Employee{Id=6,Name="Avinash",City="Mumbai",Salary=40500,Dept="HR"},
            };

            //var result=from p in empList
            //           where p.Salary<45000
            //           orderby p.Salary
            //           select p;

            //var result = from p in empList
            //             orderby p.Name
            //           select p;


            //var result = from p in empList
            //   where p.City=="Mumbai"
            //   orderby p.City
            //   select p;

            //var result = from p in empList
            // where p.Dept=="HR"
            //   orderby p.Dept
            //  select p;

            //var result = from p in empList
            //             orderby p.Salary descending
            //             select p;


            //var result = from p in empList
            //             where p.Salary <35000
            //             orderby p.City
            //             select p;

              var result = from p in empList
                         where p.Name.StartsWith('A') || p.Name.StartsWith('g')
                         orderby p.Name
                         select p;


                                                    


            foreach (Employee p in result)
            {
                Console.WriteLine($"{p.Name} {p.Salary}");
            }

        }
    }
}
