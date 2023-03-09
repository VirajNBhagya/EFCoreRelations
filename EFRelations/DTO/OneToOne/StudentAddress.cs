using System.ComponentModel.DataAnnotations.Schema;

namespace EFRelations.DTO.OneToOne
{
    [Table("StudentAddress")]
    public class StudentAddress
    {
        public int Id { get; set; }
        public string address { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
