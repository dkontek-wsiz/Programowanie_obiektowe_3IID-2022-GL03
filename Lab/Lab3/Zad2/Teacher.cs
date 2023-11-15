using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Zad2
{
    public class Teacher : Student
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public void WhichStudentCanGoHomeAlone()
        {
            foreach(var student in Students.Where(x => x.CanGoAloneToHome()))
            {
                Console.WriteLine(student.GetFullName());
            }
        }

        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{School} Data: {date.ToShortDateString()}"); 
            Console.WriteLine($"Nauczyciel: {Title} {GetFullName()}");
            Console.WriteLine($"Lista studentów");

            var i = 1;
            foreach (var student in Students)
            {
                Console.WriteLine($"{i}. {student.GetFullName()} {student.GetGender()} {student.CanGoAloneToHome()} {student.Info()}");
                i++;
            }
        }
    }
}
