namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"{TempConverter.FahrenheitToCelcius(72)}");
            Console.WriteLine($"72 degrees fahrenheit to celcius");


            Console.WriteLine($"{TempConverter.CelciusToFahrenheit(22)}");
            Console.WriteLine($"22 degrees celcius to fahrenheit");

        }
    }
}
