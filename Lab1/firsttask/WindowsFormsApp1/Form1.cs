using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Move Student class outside methods
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Marks { get; set; }
        }


        // Make lists global (class-level)
        List<int> numbers;
        List<string> names;
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numbers = new List<int>
            {
                12, 5, 8, 21, 15, 3, 18, 25, 7, 30,
                14, 9, 22, 11, 6, 17, 28, 4, 13, 20
            };

            names = new List<string>
            {
                "Jahid", "Hasan", "Rahim", "Karim", "Sakib",
                "Tamim", "Mushfiq", "Mahmudullah", "Nayeem",
                "Rakib", "Jahid", "Karim", "Sakib"
            };

            students = new List<Student>
            {
                new Student { Id = 1, Name = "Jahid", Department = "CSE", Marks = 85 },
                new Student { Id = 2, Name = "Rahim", Department = "CSE", Marks = 72 },
                new Student { Id = 3, Name = "Karim", Department = "EEE", Marks = 91 },
                new Student { Id = 4, Name = "Sakib", Department = "BBA", Marks = 67 },
                new Student { Id = 5, Name = "Tamim", Department = "CSE", Marks = 88 },
                new Student { Id = 6, Name = "Rakib", Department = "EEE", Marks = 76 },
                new Student { Id = 7, Name = "Hasan", Department = "BBA", Marks = 82 },
                new Student { Id = 8, Name = "Nayeem", Department = "CSE", Marks = 95 },
                new Student { Id = 9, Name = "Mushfiq", Department = "EEE", Marks = 69 },
                new Student { Id = 10, Name = "Mahmud", Department = "BBA", Marks = 90 },
                new Student { Id = 11, Name = "Jannat", Department = "CSE", Marks = 78 },
                new Student { Id = 12, Name = "Farzana", Department = "EEE", Marks = 84 },
                new Student { Id = 13, Name = "Nusrat", Department = "BBA", Marks = 74 },
                new Student { Id = 14, Name = "Shakil", Department = "CSE", Marks = 65 },
                new Student { Id = 15, Name = "Arif", Department = "EEE", Marks = 87 }
            };
        }
    }
}