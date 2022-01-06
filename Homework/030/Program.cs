// Task 30
Console.Write("введите первое число:            ");
double usersFirstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("введите второе число:            ");
double usersSecondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("введите шаг выведения значений:  ");
double usersStep = Convert.ToDouble(Console.ReadLine());

if (usersFirstNumber > usersSecondNumber & usersStep < 0)
{
    for (double i = usersFirstNumber; i >= usersSecondNumber; i+= usersStep)
    {
        Console.WriteLine(($"{i:f1}"));   
    }
}
else if (usersFirstNumber < usersSecondNumber & usersStep > 0)
{
    for (double i = usersFirstNumber; i <= usersSecondNumber; i += usersStep)
    {
        Console.WriteLine($"{i:f1}");
    }
}
else
{
    Console.WriteLine("введите корректные значения!");
}
Console.ReadKey();  