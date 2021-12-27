//Задание 4: выводим в консоль все цвета текста;

foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.ForegroundColor = color;
    Console.WriteLine($"Foreground color set to {color}");
}
Console.ReadKey();