using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class StudentQ1
    {
        string name { get; set; }
        int age { get; set; }
        string[] marks { get; set; }
        int score { get; set; }
        public enum feedbacks { Poor = 1, Fair, Good, VeryGood, Excellent };
        int Grade, feedback;
        StudentQ1(string name, int Age)
        {
            this.name = name;
            this.age = age;
        }
        void EnterMarks()
        {
            int sub;
            Console.WriteLine("Enter Number of subject");
            sub = Convert.ToInt32(Console.ReadLine());
            if (sub < 5)
            {
                Console.WriteLine("Subject Cannot be less than 5");
                Console.WriteLine("Enter number of subjects");
                sub = Convert.ToInt32(Console.ReadLine());
            }
            string[] marks = new string[sub];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter marks{0}", i + 1);
                marks[i] = Console.ReadLine();
            }
            this.marks = marks;
        }
        void CalculateGrade()
        {
            int TotalGrade = 0, Grade;

            for (int i = 0; i < marks.Length; i++)
            {
                TotalGrade = TotalGrade + Convert.ToInt32(marks[i]);
            }
            Grade = TotalGrade / marks.Length;
            if (Grade > 90 && Grade <= 100) feedback = (int)feedbacks.Excellent;
            else if (Grade > 75 && Grade <= 90) feedback = (int)feedbacks.VeryGood;
            else if (Grade > 40 && Grade <= 75) feedback = (int)feedbacks.Good;
            else feedback = (int)feedbacks.Poor;

            this.Grade = Grade;

        }
        public void DisplayResultMethod()
        {
            Console.WriteLine("Name : {0} grade: {1} feedback: {2}", name, Grade, (feedbacks)feedback);
        }
        static void Main()
        {
            int stud_age, stud_num;
            string stud_name;

            Console.WriteLine("Enter number of students");
            stud_num = Convert.ToInt32(Console.ReadLine());

            StudentQ1[] student = new StudentQ1[stud_num];
            for (int j = 0; j < stud_num; j++)
            {
                Console.WriteLine("Enter Student Name");
                stud_name = Console.ReadLine();
                Console.WriteLine("Enter Student age");
                stud_age = Convert.ToInt32(Console.ReadLine());

                student[j] = new StudentQ1(stud_name, stud_age);
                student[j].EnterMarks();

            }
            for (int i = 0; i < stud_num; i++)
            {
                student[i].CalculateGrade();
                student[i].DisplayResultMethod();
            }
        }
    }
}
