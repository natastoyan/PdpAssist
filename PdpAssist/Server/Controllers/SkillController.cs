using Microsoft.AspNetCore.Mvc;

namespace PdpAssist.Server.Controllers
{
	public class SkillController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
