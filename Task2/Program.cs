using Task2;

Student[] arr = new Student[2];
        for (int i = 0; i < arr.Length; i++)
        {
            Student student = new Student();

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your group");
            string group = (Console.ReadLine());

            Console.WriteLine("Enter your point");
            int point = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is Graduated:True or False");
            bool isGraduated = Convert.ToBoolean(Console.ReadLine());

            student.Name = name;
            student.Surname = surname;
            student.Group = group;
            student.Point = point;
            student.IsGraduated = isGraduated;
            arr[i] = student;
}

for (int k = 0; k < arr.Length; k++)
{
    Console.WriteLine("{");
    Console.WriteLine($"Name:{arr[k].Name}");
    Console.WriteLine($"Surname:{arr[k].Surname}");
    Console.WriteLine($"Group:{arr[k].Group}");
    Console.WriteLine($"Point:{arr[k].Point}");
    Console.WriteLine($"Is Graduated:{arr[k].IsGraduated}");
    Console.WriteLine("}");
    
}




