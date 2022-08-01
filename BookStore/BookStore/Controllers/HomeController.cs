using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // var obj = new {Id = 1, Name = "Tejal"}; 
            //return View("AboutUs", obj);
            // return View("~/TempView/TejalTemp.cshtml");   // full path
            //return View("../../TempView/TejalTemp");        //Relative path
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
