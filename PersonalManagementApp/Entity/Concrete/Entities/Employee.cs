using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Entities
{
    public class Employee : BaseEntity
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string? ReasonOfLeaving { get; set; }
        public string IdentityNumber { get; set; }
        public string Status { get; set; }
    }
}
