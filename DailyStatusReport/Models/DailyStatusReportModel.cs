using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyStatusReport.Models
{
    public class DailyStatusReportModel
    {
        public List<string> DevelopersName { get; set; }
        public List<string> ProjectName { get; set; }
        public List<string> FixVersion { get; set; }
        public List<string> Status { get; set; }
    }
}