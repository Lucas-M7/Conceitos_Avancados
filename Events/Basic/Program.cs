using Basic.Classes;

Process process = new();
process.ProcessCompleted += ProcessHandler;

process.ProcessStarted();

static void ProcessHandler()
{
    Console.WriteLine("Process completed!");
}