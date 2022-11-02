namespace TemperatureTask.Model
{
    public interface ITemperatureConvertable
    {
        double GetTemperature(double value, int inputIndex, int outputIndex);
    }
}
