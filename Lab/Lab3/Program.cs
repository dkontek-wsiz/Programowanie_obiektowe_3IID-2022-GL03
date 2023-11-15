using System;
using System.Collections.Generic;
using Lab3.Shapes;
using Lab3.Zad2;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var shapes = new List<Shape>();

             var shape1 = new Shape(5);
             shapes.Add(shape1);
             shapes.Add(new Rectangle(3));
             shapes.Add(new Rectangle(5));
             shapes.Add(new Rectangle(2));
             shapes.Add(new Rectangle(1));

             foreach(var shape in shapes) {
                 shape.Draw();
             }*/

            var pesels = new List<long>()
            {
                13292313574,
                11272558326,
                11252623556,
                14222195514,
                13260515371,
                14281248851,
                13211445544,
                13290928392,
                14240472824,
                12310555824
            };

            var teacher = new Teacher();

            teacher.SetFirstName("Nauczyciel");
            teacher.SetLastName("Nauczyciel");
            teacher.Title = "Dr";

            var students = new List<Student>();

            var i = 0;
            foreach(var pesel in pesels)
            {
                var student = new Student();
                student.SetPesel(pesel.ToString());
                student.SetFirstName("Student");
                student.SetLastName(i.ToString());
                if (i == 4)
                    student.SetCanGoHomeAlone(true);
                students.Add(student);
                i++;
            }

            teacher.Students.AddRange(students);

            teacher.WhichStudentCanGoHomeAlone();

            teacher.DisplayClass(DateTime.Today);

        }
    }
}
