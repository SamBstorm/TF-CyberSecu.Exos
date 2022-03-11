using System;

namespace TF_CyberSecu.Exos.CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.Temperature = 20;

            Fahrenheit f = c.ToFahrenheit();

            Console.WriteLine($"{c.Temperature} °C = {f.Temperature} °F");

            f.Temperature = 45;
            c = f.ToCelsius();
            Console.WriteLine($"{c.Temperature} °C = {f.Temperature} °F");
        }
    }
}
