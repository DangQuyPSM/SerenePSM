using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7231Row))]
public class Pfk7231Page : Controller
{
    [Route("Default/Pfk7231")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7231/Pfk7231Page",
            Pfk7231Row.Fields.PageTitle());
    }
}