using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementWebApp.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName  { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
