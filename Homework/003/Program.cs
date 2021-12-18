
//Задание 3: выводим в консоль все цвета текста;

int consoleColor;

for (consoleColor = 0; consoleColor <= 15; consoleColor++)
{
    Console.ForegroundColor = (ConsoleColor)consoleColor;

    Console.WriteLine("Foreground color set to " + (ConsoleColor)consoleColor);
}
Console.ReadKey();

