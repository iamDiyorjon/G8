using Models;

namespace ConsoleApp1.Services;

public partial class SchoolService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Qiymat bo'sh yoki null bo'lolmaydi!");

            return;
        }

        int id = students.Count > 0 ? students.Max(t => t.Id) + 1 : 1;
        students.Add(new Student { Id = id, Name = name });
    }

}
