using StudentManagementApi.Models;

namespace StudentManagementApi.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Create(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}