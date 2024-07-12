
using ConsoleApp1.Services;

public static class Program
{
    static void Main(string[] args)
    {
        var schoolService = new SchoolService();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add Specialist");
          
            Console.WriteLine("2. Add Teacher");
            Console.WriteLine("3. Update Specialist");
            Console.WriteLine("4. Update Teacher");
            Console.WriteLine("5. Delete Specialist");
            Console.WriteLine("6. Delete Teacher");
            Console.WriteLine("7. Attach Specialist to Teacher");
            Console.WriteLine("8. List Specialists");
            Console.WriteLine("9. List Teachers");
            Console.WriteLine("10. Get Full List");
            Console.WriteLine("11. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Specialist Name: ");
                    var sName = Console.ReadLine();
                    Console.Write("Enter Specialist Stack: ");
                    var stack = Console.ReadLine();
                    schoolService.AddSpecialist(sName, stack);
                    Console.WriteLine("Successiful added.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Teacher Name: ");
                    var tName = Console.ReadLine();
                    schoolService.AddTeacher(tName);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Specialist Id: ");
                    var sId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Specialist Name: ");
                    var newSName = Console.ReadLine();
                    Console.Write("Enter Specialist Stack: ");
                    var newStack = Console.ReadLine();
                    schoolService.UpdateSpecialist(sId, newSName, newStack);
                    Console.Clear();
                    break;
                case "4":
                    Console.Write("Enter Teacher Id: ");
                    var tId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Name: ");
                    var newTName = Console.ReadLine();
                    schoolService.UpdateTeacher(tId, newTName);
                    Console.Clear();
                    break;
                case "5":
                    Console.Write("Enter Specialist Id: ");
                    var deleteSId = int.Parse(Console.ReadLine());
                    schoolService.DeleteSpecialist(deleteSId);
                    Console.Clear();
                    break;
                case "6":
                    Console.Write("Enter Teacher Id: ");
                    var deleteTId = int.Parse(Console.ReadLine());
                    schoolService.DeleteTeacher(deleteTId);
                    Console.Clear();
                    break;
                case "7":
                    Console.Write("Enter Teacher Id: ");
                    var attTId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Specialist Id: ");
                    var attSId = int.Parse(Console.ReadLine());
                    schoolService.AttachSpecialistToTeacher(attTId, attSId);
                    Console.Clear();
                    break;
                case "8":
                    schoolService.ListSpecialists();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "9":
                    schoolService.ListTeachers();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "10":
                    schoolService.GetList();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "11":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
