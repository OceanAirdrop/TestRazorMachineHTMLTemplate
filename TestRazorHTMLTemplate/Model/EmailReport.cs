using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRazorHTMLTemplate.Model
{
    public class EmailReport
    {
        public string ReportName { get; set; }
        public int Version { get; set; }
        string Status { get; set; }
        public List<string> Problems { get; set; }

        public EmailReport()
        {
            Problems = new List<string>();
        }


    }
}
