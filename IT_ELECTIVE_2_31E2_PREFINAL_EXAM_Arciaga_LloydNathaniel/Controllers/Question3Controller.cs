using IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Controllers
{
    public class Question3Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question3ViewModel();
            return View(model);
        }
    }
}
