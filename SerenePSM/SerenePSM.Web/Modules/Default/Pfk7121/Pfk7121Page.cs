using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7121Row))]
public class Pfk7121Page : Controller
{
    [Route("Default/Pfk7121")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7121/Pfk7121Page",
            Pfk7121Row.Fields.PageTitle());
    }
}