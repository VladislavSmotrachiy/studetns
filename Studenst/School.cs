using System.Reflection.Metadata.Ecma335;

public class School
{

    public string Name;

    List<Students> Students;

    public School(string name)
    {
        Name = name;
        Students = new List<Students>();

    }

    public void AddStudens(Students students)
    {
        Students.Add(students);

    }

    public void DislpayCountStudents()
    {
        if (Students.Count == 0)
        {
            System.Console.WriteLine($" В школе {Name} нет учеников");
            return;
        }
        System.Console.WriteLine($" Список учеников школы: {Name} ");

        foreach (Students student in Students)
        {
            System.Console.WriteLine(student.GetFullName());
        }

    }


}