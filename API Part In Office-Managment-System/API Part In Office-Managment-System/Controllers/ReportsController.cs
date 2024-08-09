using API_Part_In_Office_Managment_System.Data;
using API_Part_In_Office_Managment_System.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.WebSockets;

namespace API_Part_In_Office_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly OpticsAPIContext _opticsAPIContext;

        public ReportsController(OpticsAPIContext opticsAPIContext) 
        { 
            _opticsAPIContext = opticsAPIContext;
        }

        [HttpPost]
        public IActionResult UploadReport(ReportDto report)
        {
            #region TempCode
            var Bills = new List<Bill>();
            var Payments = new List<Payment>();
            var DesOptic = new List<DestroyedOptic>();

            foreach(var bill in report.Bills) 
            {
                Bills.Add(new Bill
                {
                    Name = bill.CustomerName,
                    Price = bill.BillCost,
                });
            }

            foreach(var payment in report.payments)
            {
                Payments.Add(new Payment
                {
                    Name = payment.CustomerName,
                    Price = payment.PaidTotal,
                });
            }

            foreach(var optic in report.DestroyedOptics)
            {
                DesOptic.Add(new DestroyedOptic
                {
                    Name = optic.WorkerName,
                    Price = optic.PriceBuy,
                });
            }

            var Report = new Reports
            {
                Bills = Bills,
                DestroyedOptics = DesOptic,
                payments = Payments,
                BillsTotal = report.BillsTotal,
                PaymentsTotal = report.PaymentsTotal,
                LosesTotal = report.LosesTotal,
                ReportTime = report.ReportTime,

            };

            _opticsAPIContext.Reports.Add(Report);

            _opticsAPIContext.SaveChanges();

            #endregion

            return Ok(Report);
        }

        [HttpGet("daily")]
        public IActionResult GetDailyReport()
        {
            var report = _opticsAPIContext.Reports.Include(r => r.Bills).Include(r => r.payments).Include(r => r.DestroyedOptics).Where(r => r.ReportTime == DateTime.Today).ToList();
            return Ok(report);
        }

        [HttpGet("byday")]
        public IActionResult GetReportByDay(DateTime time)
        {
            var report = _opticsAPIContext.Reports.FirstOrDefault(r => r.ReportTime.Date == time.Date);
            return Ok(report);
        }

        [HttpGet("all")]
        public IActionResult GetAllReports()
        {
            var reports = _opticsAPIContext.Reports.Include(r => r.Bills).Include(r => r.payments).Include(r => r.DestroyedOptics).ToList();
            return Ok(reports);
        }


    }
}
