using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7104Row))]
public class Pfk7104Page : Controller
{
    [Route("Default/Pfk7104")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7104/Pfk7104Page",
            Pfk7104Row.Fields.PageTitle());
    }
}