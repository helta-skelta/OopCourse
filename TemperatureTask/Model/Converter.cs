namespace TemperatureTask.Model
{
    internal class TemperatureConverter : ITemperatureConvertable
    {
        private static double ConvertToCelsius(double value, int index)
        {
            return (index) switch
            {
                (1) => (value - 32) / 1.8,
                (2) => value - 273.15,
                _ => value
            };
        }

        public double GetTemperature(double value, int inputValueIndex, int outputValueIndex)
        {
            return (outputValueIndex) switch
            {
                (1) => ConvertToCelsius(value, inputValueIndex) * 1.8 + 32,
                (2) => ConvertToCelsius(value, inputValueIndex) + 273.15,
                _ => ConvertToCelsius(value, inputValueIndex)
            };
        }
    }
}