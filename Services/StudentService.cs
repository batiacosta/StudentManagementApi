using System.Linq.Expressions;
using Microsoft.VisualBasic;
using StudentManagementApi.Data;
using StudentManagementApi.Interfaces;
using StudentManagementApi.Models;

namespace StudentManagementApi.Services
{
    public class Studentservice : IStudentService
    {
        private readonly AppDbContext _context;
        public Studentservice(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList<Student>();
        }

        public Student GetById(int id)
        {
            var student = _context.Students.Find(id);
            return student;
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
           return student;
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            if (GetById(student.ID) == null) return;

            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}