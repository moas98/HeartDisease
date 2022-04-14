using Heart_Disease_Prediction.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heart_Disease_Prediction.Controllers
{
    public class HeartDiseaseController : Controller
    {
        private readonly AppDbContext context;

        public HeartDiseaseController(AppDbContext context)
        {
            this.context=context;
        }
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
            
            if (result !=null)
            {
                var entityModel = new entity
                {
                    Age = input.Age,
                    Ca  = input.Ca,
                    Chol = input.Chol,
                    Cp = input.Cp,
                    Exang = input.Exang,
                    Fbs = input.Fbs,
                    Label = input.Label,
                    OldPeak = input.OldPeak,
                    RestEcg = input.RestEcg,
                    Sex = input.Sex,
                    TrestBps = input.TrestBps,
                    Thal = input.Thal,
                    Slope = input.Slope,
                    Thalac = input.Thalac,
                    Prediction= result.Prediction,
                    Probability = result.Probability,
                    Score = result.Score,
                    Name =input.Name,
                };
                context.states.Add(entityModel);

                context.SaveChanges();
                ViewBag.id =entityModel.Id;
            }
            return View();
        }
    }
}
