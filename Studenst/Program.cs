using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

class Program
{

    static void Main(string[] args) 
    {
        string nameSchool = Console.ReadLine();
        School school = new School(nameSchool);
        System.Console.WriteLine($"Школа {school.Name} успешно создана. ");
        
while(true)
        {
            System.Console.WriteLine($" Хотите посмотреть список всех учеников школы {school.Name} ? ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "да" || answer == "yes" || answer == "y")
            {
                school.DislpayCountStudents();
            }

            System.Console.WriteLine(" Хотите добавить нового ученика? ");
            answer = Console.ReadLine().ToLower();

             if (answer == "да" || answer == "yes" || answer == "y")
            {
                System.Console.WriteLine("В видите имя ученика");
                string firstName = Console.ReadLine()!;
                System.Console.WriteLine("В фамилию  ученика");
                string lastName = Console.ReadLine()!;
                Students students = new Students(firstName, lastName);
                school.AddStudens(students);
                System.Console.WriteLine($" Ученик {students.GetFullName()} успешно добавлен в школу {school.Name}");

            }
       
        }
    }
}