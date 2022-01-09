// Task29;
Console.Write("введите первое число:  ");
int firstUsersNumber = int.Parse(Console.ReadLine());

Console.Write("введите второе число:  ");
int secondUsersNumber = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(@"нечётные числа между
  указанными числами: ");

int counter = firstUsersNumber;

if (firstUsersNumber > secondUsersNumber)
{
    while (counter >= secondUsersNumber)
    {
       
        if (counter % 2 != 0)
        { 
            Console.WriteLine($"{counter, 25}");
        } 
        counter--;
    }
}
else if (firstUsersNumber < secondUsersNumber)
{
    while (counter <= secondUsersNumber)
    {
       
        if (counter % 2 != 0)
        {
            Console.WriteLine($"{counter, 25}");
        } 
        counter++;
    }   
}
else if (firstUsersNumber == secondUsersNumber & firstUsersNumber % 2 != 0)
{
    Console.WriteLine($"{counter, 25}");
}
else 
{
    Console.WriteLine("числа равны между собой и являются чётными");
}
Console.ReadKey();  