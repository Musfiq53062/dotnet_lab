using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                12, 5, 8, 21, 15, 3, 18, 25, 7, 30,
                14, 9, 22, 11, 6, 17, 28, 4, 13, 20
            };
            List<string> names = new List<string>
            {
                "Jahid",
                "Hasan",
                "Rahim",
                "Karim",
                "Sakib",
                "Tamim",
                "Mushfiq",
                "Mahmudullah",
                "Nayeem",
                "Rakib",
                "Jahid",
                "Karim",
                "Sakib"
            };

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Jahid",      Department = "CSE", Marks = 85 },
                new Student { Id = 2, Name = "Rahim",      Department = "CSE", Marks = 72 },
                new Student { Id = 3, Name = "Karim",      Department = "EEE", Marks = 91 },
                new Student { Id = 4, Name = "Sakib",      Department = "BBA", Marks = 67 },
                new Student { Id = 5, Name = "Tamim",      Department = "CSE", Marks = 88 },
                new Student { Id = 6, Name = "Rakib",      Department = "EEE", Marks = 76 },
                new Student { Id = 7, Name = "Hasan",      Department = "BBA", Marks = 82 },
                new Student { Id = 8, Name = "Nayeem",     Department = "CSE", Marks = 95 },
                new Student { Id = 9, Name = "Mushfiq",    Department = "EEE", Marks = 69 },
                new Student { Id = 10, Name = "Mahmud",    Department = "BBA", Marks = 90 },
                new Student { Id = 11, Name = "Jannat",    Department = "CSE", Marks = 78 },
                new Student { Id = 12, Name = "Farzana",   Department = "EEE", Marks = 84 },
                new Student { Id = 13, Name = "Nusrat",    Department = "BBA", Marks = 74 },
                new Student { Id = 14, Name = "Shakil",    Department = "CSE", Marks = 65 },
                new Student { Id = 15, Name = "Arif",      Department = "EEE", Marks = 87 }

            };
            //1. Find all students from CSE.
            Console.WriteLine("Students from CSE department:");
            List<Student> cseStd = students.Where(x => x.Department == "CSE").ToList();
            foreach(Student std in cseStd)
            {
                Console.WriteLine(std.Name+"--->"+std.Marks);
            }
            Console.WriteLine();

            //2. Find students with marks greater than 80.
            Console.WriteLine("Students with marks greater than 80: ");
            List<Student> marks80 = students.Where(x => x.Marks > 80).ToList();
            foreach (Student std in marks80)
            {
                Console.WriteLine(std.Name + "--->" + std.Marks);
            }
            Console.WriteLine();

            //3. Count students in the EEE department.
            var countEEE = students.Where(x => x.Department == "EEE").Count();
            Console.WriteLine("No of Students in EEE departemnt: "+countEEE);
            Console.WriteLine();

            //4. Find the highest scorer.
            var highestScorer = students.OrderByDescending(x => x.Marks).First();
            Console.WriteLine("Highest Scorer: "+highestScorer.Name + " ----> "+ highestScorer.Marks );
            //5. Find the lowest scorer.
            var lowestScorer = students.OrderBy(x => x.Marks).First();
            Console.WriteLine("Lowest Scorer : " + lowestScorer.Name + " ----> " + lowestScorer.Marks);
            Console.WriteLine();

            //6. Calculate the average marks of all students.
            Console.WriteLine("Average mark: " + students.Average(x => x.Marks));

            //7. Find all students whose names start with "M".
            Console.WriteLine("Students whose name start with M: " );
            foreach(var studnet in students.Where(x => x.Name.StartsWith("M")))
            {
                Console.Write(studnet.Name+"\n");
            }

            //8. Find the average marks of CSE students.
            Console.WriteLine("Average mark of CSE students: " + cseStd.Average(x => x.Marks));
            //9. Count students who scored above 75.
            Console.WriteLine("No of Students who scored above 75: "+ students.Where(x => x.Marks > 75).Count());
            //10. Get the top 3 students by marks.
            Console.WriteLine("Top 3 students by mark: ");
            foreach(var Student in students.OrderByDescending(x => x.Marks).Take(3))
            {
                Console.WriteLine(Student.Name);
            }

            //11. Get the bottom 5 students by marks.
            Console.WriteLine("\n"+"the bottom 5 students by marks: ");
            foreach (var Student in students.OrderBy(x => x.Marks).Take(5))
            {
                Console.WriteLine(Student.Name+"-->"+Student.Marks);
            }

            //12. Find all departments available in the list.
            Console.WriteLine("\n" + "Departments list: ");
            var dept = students.Select(x => x.Department).Distinct().ToList();
            foreach (var department in dept)
            {
                Console.WriteLine(department);
            }
        }  
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Marks { get; set; }
    }
}
