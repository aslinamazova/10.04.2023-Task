namespace Task09;
class Program
{
    static void Main(string[] args)
    {
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


        Student student = new Student(name,surname,group,point,isGraduated)
        {
           
        };

        if (student.isGraduated == false)
        {
            Console.WriteLine("{");
            Console.WriteLine($"Name:{student.name}");
            Console.WriteLine($"Surname:{student.surname}");
            Console.WriteLine($"Group:{student.group}");
            Console.WriteLine($"Point:{student.point}");
            Console.WriteLine($"Is Graduated:{student.isGraduated}");
            Console.WriteLine("}");
            Console.WriteLine($"This student hasn't graduated");
            if (student.point > 80)
            {
                Console.WriteLine($"You can take the next exam.");
            }
            else
            {
                Console.WriteLine($"You can't take the next exam.");
            }
        }

        else
        {
            Console.WriteLine("{");
            Console.WriteLine($"Name:{student.name}");
            Console.WriteLine($"Surname:{student.surname}");
            Console.WriteLine($"Group:{student.group}");
            Console.WriteLine($"Point:{student.point}");
            Console.WriteLine($"Is Graduated:{student.isGraduated}");
            Console.WriteLine("}");
            Console.WriteLine($"This student has graduated.");

        }
    }
}

