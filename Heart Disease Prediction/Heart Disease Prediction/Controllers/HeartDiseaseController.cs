using Heart_Disease_Prediction.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heart_Disease_Prediction.Controllers
{
    public class HeartDiseaseController : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Predict(HeartData input)
        {
            var model = new MLModel();
            model.Build();
            var result = model.Consume(input);
            ViewBag.HeartPrediction = result;
            ViewBag.result = result;
            return View();
        }
    }
}
