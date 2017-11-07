using System.Web.Mvc;

namespace GithubResearch.Web.Controllers
{
    public class AboutController : GithubResearchControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}