namespace Task2
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public void Students(string name, string surname, string group, int point, bool isGraduated)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            this.Point = point;
            this.IsGraduated = isGraduated;
        }
    }
}