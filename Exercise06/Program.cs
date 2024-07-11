// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá!");
void PrintDate()
{
    var validOptions = new List<int>() {1, 2, 3, 4};
    Console.WriteLine("Por favor escolha o formato desejado: \n" +
                      "1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos). \n" +
                      "2 - Apenas a data no formato \"01/03/2024\" \n" +
                      "3 - Apenas a hora no formato de 24 horas. \n" +
                      "4 - A data com o mês por extenso");
    var selectedOption = Console.ReadLine();

    if (int.TryParse(selectedOption, out var validOption) && validOptions.Contains(validOption))
    {
        Console.WriteLine($"Hoje é: {PrintAnswer(validOption)}");
        return;
    }
    Console.WriteLine("Desculpe não entendi!");
    PrintDate();
}

string PrintAnswer(int validOption) => validOption switch
{
    1 => $"Hoje é: {DateTime.Now:dddd dd MMMM yyyy HH:mm:ss}",
    2 => $"Hoje é: {DateTime.Now:dd/MM/yyyy}",
    3 => $"Agora são: {DateTime.Now:HH}",
    4 => $"Hoje é: {DateTime.Now:dd} de {DateTime.Now:MMMM} de {DateTime.Now:yyyy}",
    _ => "Desculpe opção incorreta!"
};

PrintDate();