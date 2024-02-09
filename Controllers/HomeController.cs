using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        var hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ?  "Good Morning" : "Good Afternoon";
        return View("MyView", viewModel);
    }
}
