Console.Write("enter your first number:");
int usersFirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("enter your second number:");
int usersSecondNumber = Convert.ToInt32(Console.ReadLine());

if(usersFirstNumber > usersSecondNumber)
{
    while(usersFirstNumber >= usersSecondNumber)
    {
        if(usersFirstNumber % 2 != 0)
        {
          Console.WriteLine(usersFirstNumber);
        }
        usersFirstNumber--;
    }
}
else if (usersFirstNumber < usersSecondNumber)
{
    while (usersFirstNumber <= usersSecondNumber)
    {
        if (usersFirstNumber % 2 != 0)
        {
            Console.WriteLine(usersFirstNumber);
        }
        usersFirstNumber++;
    }
}
Console.ReadKey();