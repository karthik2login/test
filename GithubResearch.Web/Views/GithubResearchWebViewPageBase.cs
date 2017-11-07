using Abp.Web.Mvc.Views;

namespace GithubResearch.Web.Views
{
    public abstract class GithubResearchWebViewPageBase : GithubResearchWebViewPageBase<dynamic>
    {

    }

    public abstract class GithubResearchWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected GithubResearchWebViewPageBase()
        {
            LocalizationSourceName = GithubResearchConsts.LocalizationSourceName;
        }
    }
}