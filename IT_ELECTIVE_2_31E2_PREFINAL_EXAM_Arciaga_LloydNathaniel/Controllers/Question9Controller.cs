using IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Controllers
{
    public class Question9Controller : Controller
    {
        public IActionResult Index()
        {
            var model = new Question9ViewModel();
            return View(model);
        }
    }
}
