using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7103Row))]
public class Pfk7103Page : Controller
{
    [Route("Default/Pfk7103")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7103/Pfk7103Page",
            Pfk7103Row.Fields.PageTitle());
    }
}