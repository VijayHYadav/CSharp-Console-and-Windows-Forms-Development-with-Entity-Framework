using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    
    public class Emp
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }

        public Dept dept { get; set; }
    }
}
