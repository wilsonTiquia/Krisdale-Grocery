using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krisdale_Grocery.Model
{
    public class EmployeeModel
    {

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ContactNumber { get; set; }
        public string StartedWorking { get; set; }

        public byte[] Image { get; set; }  

    }
}
