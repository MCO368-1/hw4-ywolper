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
            return (temp - 32) / (decimal)1.8;
        }

        public static decimal CelsiusToFahrenheit(decimal temp)
        {
            return (temp * (decimal)1.8) + 32;
        }

        public static decimal KelvinToCelsius(decimal temp)
        {
            return temp - (decimal)273.15;
        }

        public static decimal CelsiusToKelvin(decimal temp)
        {
            return temp + (decimal)273.15;
        }

        public static decimal FahrenheitToKelvin(decimal temp)
        {
            return (temp + (decimal)459.67) * (decimal)5.0 / (decimal)9.0;
        }

        public static decimal KelvinToFahrenheit(decimal temp)
        {
            return (temp * (decimal)9.0 / (decimal)5.0) - (decimal)459.67;
        }
    }
}

public enum Temperature
{
    Fahrenheit,
    Celcius,
    Kelvin
};