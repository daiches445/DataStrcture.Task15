using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture.Task15
{
    enum Courses
    {
        Math ,
        C_Sharp ,
        Paython ,
        JS ,
        React,
        DataStracture

    }
    class Student
    {
        private Node<Grade> grades;
        private string fullName;
        private int ID, yearInCollage;

        public Student(string fullName, int ID, int YNC, Random rnd)
        {
            this.fullName = fullName;
            this.ID = ID;
            this.yearInCollage = YNC;

            SetGrades(rnd);

        }

        private void SetGrades(Random random)
        {
            grades = new Node<Grade>(new Grade(0, random.Next(55, 101)));
            Node<Grade> first = grades;
            for (int i = 1; i < 6; i++)
            {
                grades.SetNext(new Node<Grade>(new Grade(i, random.Next(55, 101))));
                grades = grades.GetNext();
            }

            grades = first;
        }

        public override string ToString()
        {
            return $"Name: {fullName}, ID: {ID}, YearInCollage: {yearInCollage}\n\n\tGrades:\n {grades.ToString()}\n";
        }

        public string GetName()
        {
            return fullName;
        }
        public Node<Grade> GetGrades()
        {
            return grades;
        }


    }

    class Grade
    {
        private int courseCode, grade;
        public Grade(int cc, int grade)
        {
            courseCode = cc;
            this.grade = grade;
        }

        public int GetCourseCode()
        {
            return courseCode;
        }
        public int GetGrade()
        {
            return grade;
        }

        public override string ToString()
        {
            return $"\tCourse: {Enum.GetName(typeof(Courses), courseCode)}, Grade: {grade}\n";
        }
    }
}
