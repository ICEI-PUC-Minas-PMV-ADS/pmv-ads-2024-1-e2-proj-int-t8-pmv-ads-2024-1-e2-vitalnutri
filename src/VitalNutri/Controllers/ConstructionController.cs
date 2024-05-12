using Microsoft.AspNetCore.Mvc;
using VitalNutri.Models;

namespace VitalNutri.Controllers
{
    public class ConstructionController : Controller
    {
        public IActionResult Index()
        {

            // Definindo os itens do breadcrumb
            var breadcrumbItems = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Text = "Home", Url = "/" },
                new BreadcrumbItem { Text = "Starter Page", Url = "/Home/Index" }
            };

            // Passando os itens do breadcrumb para a view
            ViewData["BreadcrumbItems"] = breadcrumbItems;
            return View("~/Views/Construction/Index.cshtml");
        }
    }
}
