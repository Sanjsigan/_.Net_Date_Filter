using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Date_Filter.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Date_Filter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _adb;

        public IndexModel(ApplicationDbContext adb)
        {
            _adb = adb;
        }

        public IEnumerable<EmpJoinDate> results { get; set; }

        public void OnGet()
        {
            results = _adb.NewEmployeeJoin.ToList();

        }
        public void OnPost(DateTime startdate, DateTime enddate)
        {
            results = (from x in _adb.NewEmployeeJoin where (x.Joindate>= startdate) && (x.Joindate <= enddate) select x).ToList();
        }
    }
}
