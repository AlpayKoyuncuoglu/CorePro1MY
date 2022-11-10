using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartment.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string User { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Password { get; set; }
    }
}
