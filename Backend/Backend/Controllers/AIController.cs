using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class AIController : ControllerBase
    {

        [HttpGet("ai")]
        public async Task<ActionResult<Prediction>> GetHousePricePrediction( float size )
        {
            var price = GetAIPredicition(size);
            //
            return Ok(price);
        }


        HouseData[] houseData = [
            new HouseData() { Size = 1.1F, Price = 1.2F },
            new HouseData() { Size = 1.9F, Price = 2.3F },
            new HouseData() { Size = 2.8F, Price = 3.0F },
            new HouseData() { Size = 3.4F, Price = 3.7F },
            new HouseData() { Size = 10.3F, Price = 11.3F },
            new HouseData() { Size = 11.1F, Price = 12.2F },
            new HouseData() { Size = 11.9F, Price = 13.1F },
            new HouseData() { Size = 12.7F, Price = 14.0F },
            new HouseData() { Size = 13.5F, Price = 15.0F },
            new HouseData() { Size = 14.3F, Price = 16.0F },
            new HouseData() { Size = 15.1F, Price = 17.0F },
            new HouseData() { Size = 15.9F, Price = 18.0F },
            new HouseData() { Size = 16.7F, Price = 19.0F },
            new HouseData() { Size = 17.5F, Price = 20.0F }
            ];


        Prediction GetAIPredicition( float houseSize )
        {
            var context = new MLContext();

            //mlContext.GpuDeviceId = 1215439946536128734 <-> 10DE 1C31 131B 10DE‬

            // 1. Import or create training data
            var trainingData = context.Data.LoadFromEnumerable(houseData);

            // 2. Specify data preparation and model training pipeline
            var pipeline = context.Transforms.Concatenate("Features", new[] { "Size" })
                .Append(context.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 100));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            // 4. Make a prediction
            var houseToPredict = new HouseData() { Size = houseSize };
            var prediction = context.Model.CreatePredictionEngine<HouseData, Prediction>(model).Predict(houseToPredict);

            return prediction;
        }
    }


    public class HouseData
    {
        public float Size { get; set; }
        public float Price { get; set; }
    }

    public class Prediction
    {
        [ColumnName("Score")]
        public float Price { get; set; }
    }

}
