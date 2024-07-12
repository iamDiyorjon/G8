namespace Models;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StrudentCount { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public List<GroupStudents> GroupStudents { get; set; } //1,3
}
