namespace Models;

public class GroupStudents
{
    public int Id { get; set; }
    public int GroupId { get; set; } //1 , //1
    public Group Group { get; set; }
    public int StudentId { get; set; } // 1 , //2
    public Student Student { get; set; }
}
