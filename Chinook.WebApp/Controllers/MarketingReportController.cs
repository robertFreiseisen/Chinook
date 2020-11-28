using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarketingReportController : ControllerBase
    {
        [HttpGet("timetrack")]
        public IEnumerable<Contracts.Report.Marketing.ITrackTime> GetTrackTimeReport()
        {
            return Report.MarketingReports.GetTrackTimes();
        }

        [HttpGet("timealbum")]
        public IEnumerable<Contracts.Report.Marketing.IAlbumTime> GetAlbumTimeReport()
        {
            return Report.MarketingReports.GetAlbumTime();
        }
    }
}
