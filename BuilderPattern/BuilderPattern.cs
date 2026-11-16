using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.BuilderPattern
{

    using System;

    public class Student
    {
        public string Name;

        public int Maths;
        public int Science;
        public int Social;
        public int Computer;
    }

    // Builder class
    public class StudentBuilder
    {
        private Student student = new Student();

        public StudentBuilder SetName(string name)
        {
            student.Name = name;
            return this;
        }
        public StudentBuilder SetMaths(int marks)
        {
            student.Maths = marks;
            return this;
        }

        public StudentBuilder SetScience(int marks)
        {
            student.Science = marks;
            return this;
        }

        public StudentBuilder SetSocial(int marks)
        {
            student.Social = marks;
            return this;
        }

        public StudentBuilder SetComputer(int marks)
        {
            student.Computer = marks;
            return this;
        }

        public Student Build()
        {
            return student;
        }
    }
}