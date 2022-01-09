//Task13. Задача про субсидии;

Console.Write("Вы пенсионер? (да/нет) ");
bool isPensioner = Console.ReadLine() == "да";

Console.Write("Состоите на учете в службе занятости? (да/нет) ");
bool isUnemploymend = Console.ReadLine() == "да";

Console.Write("Работаете (да/нет)?  ");
bool isEmploymend = Console.ReadLine() == "да";

bool subsidyAllowed =
    (isPensioner == true & isEmploymend == false) ^
    (isEmploymend == false & isUnemploymend == true & isPensioner == false);

if (subsidyAllowed)
{
    Console.WriteLine("Субсидия Вам доступна!");
}
else
{
    Console.WriteLine("Субсидия Вам недоступна!");
}
Console.ReadKey();