namespace Challenge.Models;

// Delegate para o evento
public delegate void EventHandler();

public class Thermometer
{
    // Temperatura atual
    public double Temperature { get; set; }

    // Temperatura limite
    public double TemperatureLimit { get; set; }

    // Evento baseado no delegate
    public event EventHandler TemperatureExceeded = delegate { }; // Manipulador vazio

    // Método que verifica a temperatura
    public void CheckTemperature()
    {
        Console.WriteLine("Verificando a temperatura...\n");
        Thread.Sleep(1000);

        if(Temperature > TemperatureLimit)
        {
            Console.WriteLine($"A temperatura atual é de: {Temperature} C°");
            OnTemperatureExceeded(); // Chamando o método que invoca a função
        }
        else
        {
            Console.WriteLine($"A temperatura atual é de: {Temperature} C°, está tudo OK!");
        }
    }

    // Método que invoca a função
    protected void OnTemperatureExceeded()
    {
        TemperatureExceeded?.Invoke();
    }
}