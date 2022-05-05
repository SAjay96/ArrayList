using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class Student
    
        {


        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Percentage{ get; set; }
        public string Branch { get; set; }  
    }

    class too
    {
        public static void Main()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student{RollNo=1,Name="Akshay",Percentage="60",Branch="Computer"},
                new Student{RollNo=18,Name="Aniket",Percentage="70",Branch="IT"},
                new Student{RollNo=11,Name="Mahavir",Percentage="80",Branch="Computer"},
                new Student{RollNo=13,Name="Ganesh",Percentage="58",Branch="Civil"},
                new Student{RollNo=29,Name="Swapnil",Percentage="75",Branch="Civil"},
                new Student{RollNo=8,Name="Ankit",Percentage="75",Branch="E&TC"},

            };

        

            var result = from  s in studentList
                         where s.Name.StartsWith('A') || s.Name.StartsWith('M')
                         orderby s.Name
                         select s;





            foreach (Student s in result)
            {
                Console.WriteLine($"{s.Name} {s.Percentage}");
            }

        }
    }
    
}

