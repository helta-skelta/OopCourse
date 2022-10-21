using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureTask.Model
{
    internal static class Converter
    {
        internal static Func<double, double> GetConvertType(int inputComboBoxValueIndex, int outputComboBoxValueIndex)
        {
            Func<double, double> op = (inputComboBoxValueIndex, outputComboBoxValueIndex) switch
            {
                (0, 1) => GetCelsiusToFahrenheit,
                (0, 2) => GetCelsiusToKelvin,
                (1, 0) => GetFahrenheitToCelsius,
                (1, 2) => GetFahrenheitToKelvin,
                (2, 0) => GetKelvinToCelsius,
                (2, 1) => GetKelvinToFahrenheit,
                _ => x => x
            };

            return op;
        }

        private static double GetCelsiusToFahrenheit(double temperatureValue)
        {
            return temperatureValue * 1.8 + 32;
        }

        private static double GetCelsiusToKelvin(double temperatureValue)
        {
            return temperatureValue + 273.15;
        }

        private static double GetFahrenheitToCelsius(double temperatureValue)
        {
            return (temperatureValue - 32) / 1.8;
        }

        private static double GetFahrenheitToKelvin(double temperatureValue)
        {
            return (temperatureValue + 459.67) * 5 / 9;
        }

        private static double GetKelvinToCelsius(double temperatureValue)
        {
            return temperatureValue - 273.15;
        }

        private static double GetKelvinToFahrenheit(double temperatureValue)
        {
            return temperatureValue / (5 / 9) - 459.67;
        }
    }
}