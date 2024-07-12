using Models;

namespace ConsoleApp1.Services;

public partial class SchoolService
{
    private List<Specialist> specialists = new List<Specialist>();
    private List<Group> groups = new List<Group>();

    public void AddSpecialist(string name, string stack)
    {
        //int id;
        //if (specialists.Count > 0)
        //{
        //    id = specialists.Max(x => x.Id) + 1;
        //}
        //else
        //{
        //    id = 1;
        //}

        int id = specialists.Count > 0 ? specialists.Max(s => s.Id) + 1 : 1;
        var spec = new Specialist { Id = id, Name = name, Stack = stack };


        specialists.Add(spec);
    }

    public void UpdateSpecialist(int id, string name, string stack)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
        {
            specialist.Name = name;
            specialist.Stack = stack;
        }
        else
        {
            Console.WriteLine("Specialist not found.");
        }
    }

    public void DeleteSpecialist(int id)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
        {
            specialists.Remove(specialist);
        }
        else
        {
            Console.WriteLine("Specialist not found.");
        }
    }

    public void AttachSpecialistToTeacher(int teacherId, int specialistId)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var specialist = specialists.FirstOrDefault(s => s.Id == specialistId);

        if (teacher == null || specialist == null)
        {
            Console.WriteLine("Invalid teacher or specialist ID.");
            return;
        }

        var teacherSpecialist = new TeacherSpecialist
        {
            TeacherId = teacherId,
            Teacher = teacher,
            SpecialistId = specialistId,
            Specialist = specialist
        };

        teacher.TeacherSpecialists.Add(teacherSpecialist);
        specialist.TeacherSpecialists.Add(teacherSpecialist);
    }

    public void GetList()
    {
        if (teachers.Count > 0)
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher: {teacher.Name}");
                foreach (var ts in teacher.TeacherSpecialists)
                {
                    Console.WriteLine($"  Specialist: {ts.Specialist.Name}, Stack: {ts.Specialist.Stack}");
                }
            }
        else
            Console.WriteLine("Teacher lis is empty.");
    }

    public void ListSpecialists()
    {
        foreach (var specialist in specialists)
        {
            Console.WriteLine($"Specialist: {specialist.Id}, Name: {specialist.Name}, Stack: {specialist.Stack}");
        }
    }
}
