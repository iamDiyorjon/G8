namespace Models;

public class Specialist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Stack { get; set; }
    public List<TeacherSpecialist> TeacherSpecialists { get; set; } = new List<TeacherSpecialist>(); //
}
