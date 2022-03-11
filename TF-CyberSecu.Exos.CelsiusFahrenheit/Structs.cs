namespace TF_CyberSecu.Exos.CelsiusFahrenheit
{
    public struct Celsius
    {
        public double Temperature;

        //Ajoutez une méthode qui donne un objet de type Fahrenheit (Formule : (t * (9/5)) + 32 )
        public Fahrenheit ToFahrenheit() {
            Fahrenheit f;
            f.Temperature = (Temperature * (9 / 5.0)) + 32;
            return f;
        }
    }

    public struct Fahrenheit {
        public double Temperature;

        //Ajoutez une méthode qui donne un objet de type Celsius (Formule : (t - 32) * (5/9) )
        public Celsius ToCelsius()
        {
            Celsius c;
            c.Temperature = (Temperature - 32) * (5/9.0);
            return c;
        }
    }
}
