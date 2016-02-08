using DailyStatusReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DailyStatusReport.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/
        public ActionResult Index()
        {
            DailyStatusReportModel reportModel = new DailyStatusReportModel();
            reportModel.DevelopersName = new List<string>()
            {
                "Abhishek", "Chahat", "Dilipan", "Gajendra Chauhan", "Girish", "Harish Hanurnagaraju", "Harun", "JaiKumar", "Lakshmi", "Muhil", "Mayank", "Praveen Pawar",
                "Praveen Khare", "Sourabh", "Sai", "Sayanta", "Vivek", "Vineesh", "Vishnu", "Venkateshwari"
            };
            reportModel.ProjectName = new List<string>() 
            {
                "NLO", "NUI", "RLO", "ALWS"
            };
            reportModel.Status = new List<string>()
            { 
                "New", "Ready", "Dev", "CodeReview", "QA"
            };
            reportModel.FixVersion = new List<string>()
            {
                "Alpine", "BlackHawk", "Cheetah", "Dino", "Service Pack Jan", "Eagle", "FireBird", "Ice Box"
            };
            return View(reportModel);
        }

        //POST: /SaveDetails
        [HttpPost]
        public bool SaveDetails(string devName, string fixVersion, string project, int ticketNumber, string ticketDescription, string ticketStatus,
                                string codeReviewId, string remark, string blocker)
        {
            try
            {
                var entity = new DailyStatusReportEntities();
                var reportTable = new tbl_dailyStatusReportData()
                {
                    DeveloperName = devName,
                    FixVersion = fixVersion,
                    Project = project,
                    TicketNumber = ticketNumber,
                    TicketDescription = ticketDescription,
                    TicketStatus = ticketStatus,
                    CrucibleId = codeReviewId,
                    Remark = remark,
                    Blocker = blocker
                };
                entity.tbl_dailyStatusReportData.Add(reportTable);
                entity.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }
	}
}