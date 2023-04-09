using System;
using System.Drawing;

namespace Task09
{
	public class Student
	{

        public Student(string name, string surname, string group, int point, bool isGraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.isGraduated = isGraduated;
        }

        public string name;
        public string surname;
        public string group;
        public int point;
        public bool isGraduated;
    }
}

