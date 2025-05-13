using generics.Entities;
using generics.Interfaces;
using generics.Repository;

namespace generics.Hierarchy;

public class Group 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IRepository<Student,int> _students = new InMemoryRepository<Student,int>();

    public void AddStudent(Student s)
    {
        _students.Add(s.Id, s);
    }

    public void RemoveStudent(int studentId)
    {
        _students.Remove(studentId);
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return _students.GetAll();
    }

    public Student FindStudent(int studentId)
    {
        return _students.Get(studentId);
    }
}