using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers     //be sure to use your own project's namespace!
{
    public class RazorController : Controller 
    {
        //for each route this controller is to handle:
        [HttpGet("")]       
        public ViewResult Index()
        {
            return View();
        }
    }
}