using generics.Entities;
using generics.Interfaces;
using generics.Repository;

namespace generics.Hierarchy;

public class Faculty
{
    public int Id {get; set;}
    public string Name {get; set;}
    private IRepository<Group,int> _groups = new InMemoryRepository<Group,int>();

    public void AddGroup(Group g)
    {
        _groups.Add(g.Id, g);
    }

    public void RemoveGroup(int id)
    {
        _groups.Remove(id);
    }

    public IEnumerable<Group> GetAllGroups()
    {
        return _groups.GetAll();
    }

    public void GetGroup(int id)
    {
        _groups.Get(id);
    }

    public void AddStudentToGroup(int groupId, Student s)
    {
        _groups.Get(groupId).AddStudent(s);
    }

    public void RemoveStudentFromGroup(int groupId, int studentId)
    {
        _groups.Get(groupId).RemoveStudent(studentId);
    }

    public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
    {
        return _groups.Get(groupId).GetAllStudents();
    }

    public Student FindStudentInGroup(int groupId, int studentId)
    {
        return _groups.Get(groupId).FindStudent(studentId);
    }
}