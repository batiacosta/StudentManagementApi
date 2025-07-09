namespace StudentManagementApi.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int TermID { set; get; }
        public Term Term { set; get; }

        public ICollection<Enrollment> Enrollments{ get; set; }
    }
}