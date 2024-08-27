using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenePSM.Default.Pages;

[PageAuthorize(typeof(Pfk7106Row))]
public class Pfk7106Page : Controller
{
    [Route("Default/Pfk7106")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Pfk7106/Pfk7106Page",
            Pfk7106Row.Fields.PageTitle());
    }
}