// Task26;
Console.Write("введите строку: ");
string usersString = Console.ReadLine();
char[] usersChars = usersString.ToCharArray();

char[] resultChars = new char[(usersChars.Length * 3)];

for (int i = 0; i < (usersChars.Length); i ++)
{
    resultChars[i] = usersChars[i];
}

int usersCharsIndex = 0;
 
for (int i = resultChars.Length - 1; i > usersChars.Length ; i-=2)
{
    resultChars[i] = usersChars[usersCharsIndex];
    if (i > usersChars.Length+1)
    {
        resultChars[i - 1] = '*';
    }
    usersCharsIndex++;
}
string resultString = string.Join("", resultChars);
Console.WriteLine($"новая строка  : {resultString,15}");

Console.ReadKey();