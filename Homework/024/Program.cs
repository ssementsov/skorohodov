//Task24;
Console.Write("введите первую строку:  ");
string firstString = Console.ReadLine();
char[] firstChars = firstString.ToCharArray();

Console.Write("введите вторую строку:  ");
string secondString = Console.ReadLine();
char[] secondChars = secondString.ToCharArray();

char[] resultChars = new char[(firstString.Length + secondString.Length)];

int firstCharIndex = 0;
int secondCharIndex = 0;

for (int i = 0; i < resultChars.Length; i += 2)
{
    resultChars[i] = firstChars[firstCharIndex++];
    resultChars[i + 1] = secondChars[secondCharIndex++];
}
string resultString = string.Join("", resultChars);
Console.WriteLine($"новая строка: {resultString,20}");

Console.ReadKey();