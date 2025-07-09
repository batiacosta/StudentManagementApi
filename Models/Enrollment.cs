namespace StudentManagementApi.Models
{
    public class Enrollment
    {
        public int ID { set; get; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

        public decimal Grade { get; set; }

    }
}