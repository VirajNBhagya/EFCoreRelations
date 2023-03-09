using System.ComponentModel.DataAnnotations.Schema;

namespace EFRelations.DTO.OneToOne
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public StudentAddress StudentAddress { get; set; }

        [NotMapped]
        public int Age { get; set; }
    }
}
