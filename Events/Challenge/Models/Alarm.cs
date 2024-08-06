namespace Challenge.Models;

public class Alarm
{

    // Sobscrevendo a função da classe Thermomemter
    public void OnTemperatureExceeded()
    {
        Console.WriteLine("Alerta! A temperatura excedeu o limite!");
    }
}