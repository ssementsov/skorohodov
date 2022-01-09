// Task27;
Console.Write("введите Вашу строку:      ");
string usersString = Console.ReadLine();
char [] chars = usersString.ToCharArray();

char [] usersNumbers = new char [chars.Length*2];

foreach (char c in chars)
{
    bool isItNumber = (c == '0' || c == '1' || c == '2' || c == '3' ||
                       c == '4' || c == '5' || c == '6' || c == '7' ||
                       c == '8' || c == '9');
    int usersNumber = 0;
    if (isItNumber)
    {
        usersNumbers[usersNumber] = (char)c;
        usersNumbers[usersNumber + 1] = '+';
        usersNumber +=2;
    }
        }
foreach (char c in usersNumbers)
    Console.Write(c);

Console.ReadKey();  