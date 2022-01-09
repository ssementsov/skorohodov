string[] monthArray = {"January", "February", "March", "April"," May","June", "July",
                 "August", "September", "October", "November", "December" };
foreach(string monthStr in monthArray)
{
    Console.WriteLine(monthStr);
}
Console.WriteLine("enter all month from first to last");
Console.Write("enter first month:  ");
for(int i = 0; i < 12; i++)
{
    string usersMonth = Console.ReadLine();
    bool isUsersMonthCorrect = usersMonth == monthArray[i];

    if (!isUsersMonthCorrect)
    {
        if (i == 4 && !isUsersMonthCorrect)
        {
            Console.Write("bye!");
            break;
        }
        else
        {
            Console.Write("incorrect! Try again: ");
            i--;
        }
    }
    else if (isUsersMonthCorrect)
    {
        Console.Write("Ok. Enter next month: ");
    }
}
Console.ReadKey();