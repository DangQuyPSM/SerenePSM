using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7155Row))]
public class Pfk7155Page : Controller
{
    [Route("Default/Pfk7155")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7155/Pfk7155Page",
            Pfk7155Row.Fields.PageTitle());
    }
}