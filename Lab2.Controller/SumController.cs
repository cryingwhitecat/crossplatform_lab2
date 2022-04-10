using Lab2.Model;

namespace Lab2.Controller
{
    public class SumController
    {
        public SumParamsModel ParamsModel { get; private set; } = new SumParamsModel();
        public SumResultModel SumModel { get; private set; } = new SumResultModel();
        public void CalculateSum()
        {
            SumModel.Sum = ParamsModel.A + ParamsModel.B;
        }
    }
}