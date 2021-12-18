
//Задание 4: выводим в консоль все цвета фона;

int consoleColor;

for (consoleColor = 0; consoleColor <= 15; consoleColor++)
{
    Console.BackgroundColor = (ConsoleColor)consoleColor;

    Console.WriteLine("Background color set to " + (ConsoleColor)consoleColor);
}
Console.ReadKey();

