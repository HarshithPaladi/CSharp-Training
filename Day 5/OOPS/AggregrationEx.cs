using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AggregrationEx
    {
        public class Student
        {
            string name;
            int age;
            int rollno;
            int dept_id;
            Marks M;
            public Student(string name, int age, int rollno, int dept_id, Marks m)
            {
                this.name = name;
                this.age = age;
                this.rollno = rollno;
                this.dept_id = dept_id;
                this.M = m;
                Display();
            }
            public void Display()
            {
                Console.WriteLine($"Name : {name}, Age : {age}, rollno: {rollno}\ndept_id: {dept_id}, Total Marks : {M.total_marks}");
                M.PercentageCalc();
                Console.WriteLine($"Percentage is {M.percentage}");
            }
        }
        public class Marks
        {
            public int total_marks;
            public float percentage;
            string grade;
            int nof_subjects;
            public Marks(int total_marks, int nof_subjects)
            {
                this.total_marks = total_marks;
                this.nof_subjects = nof_subjects;
            }
            public void PercentageCalc()
            {
                percentage = total_marks / nof_subjects;
                Console.WriteLine(percentage);
            }
        }
    }
}
