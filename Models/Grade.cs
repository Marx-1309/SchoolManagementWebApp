namespace SchoolManagementWebApp.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public string GradeValue { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}
