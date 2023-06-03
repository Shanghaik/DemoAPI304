using Microsoft.AspNetCore.Mvc;

namespace AppViews.Controllers
{
    public class ValidateController : Controller
    {
        public IActionResult CreateToCheck()
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return Content("Thất nghiệp rồi");
        }
    }
}
