using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7171Row))]
public class Pfk7171Page : Controller
{
    [Route("Default/Pfk7171")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7171/Pfk7171Page",
            Pfk7171Row.Fields.PageTitle());
    }
}