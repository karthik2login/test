using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace GithubResearch.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GithubResearchControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}