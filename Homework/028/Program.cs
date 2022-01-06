// Task28;
Console.Write("введите целое число: ");
int usersNumber = int.Parse(Console.ReadLine());

if (usersNumber >= 0)
{
    while (usersNumber >= 0)
    {
        Console.WriteLine(usersNumber--);
    }
}
else
{
    while (usersNumber <= 0)
    {
        Console.WriteLine(usersNumber++);
    }
}
Console.ReadKey();