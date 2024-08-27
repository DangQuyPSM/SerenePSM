using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7105Row))]
public class Pfk7105Page : Controller
{
    [Route("Default/Pfk7105")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7105/Pfk7105Page",
            Pfk7105Row.Fields.PageTitle());
    }
}