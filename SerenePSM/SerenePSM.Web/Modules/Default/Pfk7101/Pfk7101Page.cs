using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7101Row))]
public class Pfk7101Page : Controller
{
    [Route("Default/Pfk7101")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7101/Pfk7101Page",
            Pfk7101Row.Fields.PageTitle());
    }
}