namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new Models.BMI();
            BMI.Height = 169;
            BMI.Weight = 79;
        }
    }
}
