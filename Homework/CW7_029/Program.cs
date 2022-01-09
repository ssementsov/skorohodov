Console.Write("enter your  number:");
int usersNumber = Convert.ToInt32(Console.ReadLine());
if (usersNumber > 0)
{
    while (usersNumber >= 0)
    {
        Console.WriteLine(usersNumber--);
    }
}
else if    (usersNumber < 0)
{
    while (usersNumber >= 0)
    {
        Console.WriteLine(usersNumber++);
    }
}
Console.ReadKey();  