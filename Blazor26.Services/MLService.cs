using Blazor26.Services.BusinessModels;
using Microsoft.ML;

namespace Blazor26.Services
{
    public class MLService
    {
        private readonly MLContext _mlContext;
        private ITransformer _model;

        public MLService()
        {
            _mlContext = new MLContext();
        }

        public void Train(List<SalesData> data)
        {
            System.Diagnostics.Debug.WriteLine("Trainmodel Service");

            if (data == null || !data.Any())
                throw new Exception("No data to train on!");

            var dataView = _mlContext.Data.LoadFromEnumerable(data);

            var pipeline = _mlContext.Transforms
                .Concatenate("Features", nameof(SalesData.Month))
                .Append(_mlContext.Regression.Trainers.Sdca(
                    labelColumnName: nameof(SalesData.SalesAmount)));

            _model = pipeline.Fit(dataView);
        }

        public float Predict(float month)
        {
            System.Diagnostics.Debug.WriteLine("in the Predict Service");

            if (_model == null)
                throw new InvalidOperationException("Model has not been trained.");

            var engine = _mlContext.Model
                .CreatePredictionEngine<SalesData, SalesPrediction>(_model);

            var result = engine.Predict(new SalesData
            {
                Month = month
            });

            return result.Score;
        }
    }
}