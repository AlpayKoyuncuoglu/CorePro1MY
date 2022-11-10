using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Personel> Personels{ get; set; }
    }
}
