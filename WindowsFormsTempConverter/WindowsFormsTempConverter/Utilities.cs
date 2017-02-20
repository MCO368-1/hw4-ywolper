using System;

namespace WindowsFormsTempConverter
{
    public class Utilities
    {
        public static decimal TemperatureConversion(decimal temp, Temperature from, Temperature to)
        {
            if (from == to)
            {
                return temp;
            }

            switch (from)
            {
                case Temperature.Fahrenheit:
                    return to == Temperature.Celcius ? FahrenheitToCelsius(temp) : FahrenheitToKelvin(temp);

                case Temperature.Celcius:
                    return to == Temperature.Fahrenheit ? CelsiusToFahrenheit(temp) : CelsiusToKelvin(temp);

                case Temperature.Kelvin:
                    return to == Temperature.Fahrenheit ? KelvinToFahrenheit(temp) : KelvinToCelsius(temp);

                default:
                    throw new ArgumentOutOfRangeException(nameof(@from), @from, null);
            }
        }

        public static decimal FahrenheitToCelsius(decimal temp)
        {
            return (temp - 32) / 1.8m;
        }

        public static decimal CelsiusToFahrenheit(decimal temp)
        {
            return (temp * 1.8m) + 32;
        }

        public static decimal KelvinToCelsius(decimal temp)
        {
            return temp - 273.15m;
        }

        public static decimal CelsiusToKelvin(decimal temp)
        {
            return temp + 273.15m;
        }

        public static decimal FahrenheitToKelvin(decimal temp)
        {
            return (temp + 459.67m) * 5.0m / 9.0m;
        }

        public static decimal KelvinToFahrenheit(decimal temp)
        {
            return (temp * 9.0m / 5.0m) - 459.67m;
        }
    }
}

public enum Temperature
{
    Fahrenheit,
    Celcius,
    Kelvin
};