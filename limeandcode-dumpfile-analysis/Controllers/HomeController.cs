using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using limeandcode_dumpfile_analysis.Models;
using System.Threading;
using System.Text;

namespace limeandcode_dumpfile_analysis.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult BuggyAction()
		{
			StringBuilder sb = new StringBuilder();
			int i = 0;
			while (true)
			{
				i++;

				if (i == 1000)
				{
					break;
				}
				Thread.Sleep(1000);
			}

			return new JsonResult(sb.ToString());
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
