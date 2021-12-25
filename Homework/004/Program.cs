//Задание 5поп: выводим в консоль все цвета фона;

foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.BackgroundColor = color;
    Console.WriteLine($"Background color set to {color}");
}
Console.ReadKey();