namespace StudentManagementApi.Models
{
    public class Term
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses{ get; set; }
    }
}