using Models;

namespace ConsoleApp1.Services;

public partial class SchoolService
{
    private List<Teacher> teachers = new List<Teacher>();

    public void AddTeacher(string name)
    {
        int id = teachers.Count > 0 ? teachers.Max(t => t.Id) + 1 : 1;
        teachers.Add(new Teacher { Id = id, Name = name });
    }

    public void UpdateTeacher(int id, string name)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            teacher.Name = name;
        }
        else
        {
            Console.WriteLine("Teacher not found.");
        }
    }

    public void DeleteTeacher(int id)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            teachers.Remove(teacher);
        }
        else
        {
            Console.WriteLine("Teacher not found.");
        }
    }

    public void ListTeachers()
    {
        foreach (var teacher in teachers)
        {
            Console.WriteLine($"Teacher: {teacher.Id}, Name: {teacher.Name}");
        }
    }
}
