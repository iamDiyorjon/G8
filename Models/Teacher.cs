namespace Models;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public List<TeacherSpecialist> TeacherSpecialists { get; set; } = new List<TeacherSpecialist>();
}
