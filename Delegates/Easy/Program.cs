using Easy.Classes;

Calculator calculator = new();
Operation operation;

operation = calculator.Sum;
Console.WriteLine($"Sum: {operation(7, 7)}");

operation = calculator.Subtract;
Console.WriteLine($"Subtract: {operation(7, 7)}");

operation = calculator.Multiply;
Console.WriteLine($"Multiply: {operation(7, 7)}");

operation = calculator.Divide;
Console.WriteLine($"Divide: {operation(7, 7)}");

Hello hello = new();
Saudation saudation;

saudation = hello.Message;
Console.WriteLine($"\n{saudation("Hello Jake")}");