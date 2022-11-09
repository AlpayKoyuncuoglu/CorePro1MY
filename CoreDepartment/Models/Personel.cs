using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
    public class Personel
    {
        [Key]
        public int PerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public Department Department { get; set; }
    }
}
