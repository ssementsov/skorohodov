// Task 25;
Console.Write("введите строку: ");
string usersString = Console.ReadLine();
char[] usersChars = usersString.ToCharArray();

char[] resultChars = new char[(usersString.Length*3)];

int usersCharIndex = 0;

for (int i = 0; i < (resultChars.Length-2); i += 3)
{
    resultChars[i] = usersChars[usersCharIndex++];
    resultChars[i + 1] = '-';
    resultChars[i + 2] = resultChars[i];
}
string resultString = string.Join("", resultChars);
Console.WriteLine($"новая строка  : {resultString,15}");

Console.ReadKey();