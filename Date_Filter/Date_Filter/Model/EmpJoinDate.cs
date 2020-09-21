using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Date_Filter.Model
{
    public class EmpJoinDate
    {
        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Email { get; set; }

        public char Gender { get; set; }

        public DateTime Joindate { get; set; }
    }
}
