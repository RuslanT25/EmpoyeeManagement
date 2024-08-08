using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
