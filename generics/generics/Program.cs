using generics.Entities;
using generics.Hierarchy;
using generics.Interfaces;
using generics.Repository;

class Program
{
    static void Main(string[] args)
    {
        // Test your lab here
        var group1 = new Group{Id = 41, Name = "KP"};
        var group2 = new Group{Id = 42, Name = "KV"};
        var group3 = new Group{Id = 43, Name = "KM"};
        var faculty = new Faculty{Id = 121, Name = "FAM"};
        faculty.AddGroup(group1);
        faculty.AddGroup(group2);
        faculty.AddGroup(group3);
        IReadOnlyRepository<Student,int> studRepo = new InMemoryRepository<Student,int>();
        IReadOnlyRepository<Person,int>  persRepo = studRepo;  // має компілюватися
        foreach (var g in faculty.GetAllGroups())
        {
            Console.WriteLine(g);
        }
        //Stukalenko yaroslav KP-41
    }
}