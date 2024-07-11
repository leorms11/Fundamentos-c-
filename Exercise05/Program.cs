// See https://aka.ms/new-console-template for more information

Console.WriteLine("Por favor, digite sua placa:");
var plate = Console.ReadLine();
Console.WriteLine($"{plate.Length == 7 && !int.TryParse(plate[..3], out _) && int.TryParse(plate[3..], out _)}");
