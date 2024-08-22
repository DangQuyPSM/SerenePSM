using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7411Row))]
public class Pfk7411Page : Controller
{
    [Route("Default/Pfk7411")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7411/Pfk7411Page",
            Pfk7411Row.Fields.PageTitle());
    }
}