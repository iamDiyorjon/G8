namespace Models;

public class TeacherSpecialist
{
    public int TeacherId { get; set; } 
    public Teacher Teacher { get; set; } 
    public int SpecialistId { get; set; }
    public Specialist Specialist { get; set; }
}
