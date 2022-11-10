using System.Collections.Generic;

namespace CoreDepartment.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Personel> Personels{ get; set; }
    }
}
