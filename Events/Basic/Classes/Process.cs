namespace Basic.Classes;

// Declaração do delegado para o evento
public delegate void Notify();

public class Process
{
    // Declaração do evento com base no delegado
    public event Notify ProcessCompleted = delegate { };

    public void ProcessStarted()
    {
        Console.WriteLine("Process Started.");
        Thread.Sleep(1000);
        Console.WriteLine("Loading........");
        Thread.Sleep(1000);

        // Chamando o método que dispara o evento
        OnProcessCompleted();
    }

    // Método que invoca o evento
    protected void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}