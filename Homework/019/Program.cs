//Task19;
Console.Write("введите первое число (координата х):  ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число (координата y):  ");
int y = Convert.ToInt32(Console.ReadLine());

bool firstQuarter = (x > 0 && y > 0);
string belongToFirstQarter = "точка принадлежит к первой четверти";

bool secondQuarter = (x < 0 && y > 0);
string belongToSecondQarter = "точка принадлежит к второй четверти";

bool thirdQuarter = (x < 0 && y < 0);
string belongToThirdQarter = "точка принадлежит к третьей четверти";

bool fourthQuarter = (x > 0 && y < 0);
string belongToFourthQarter = "точка принадлежит к четвёртой четверти";

string zeroZero = "координаты точки 0;0";

string result = firstQuarter ? belongToFirstQarter :
                secondQuarter ? belongToSecondQarter :
                thirdQuarter ? belongToThirdQarter :
                fourthQuarter ? belongToFourthQarter : zeroZero;

Console.WriteLine(result);

Console.ReadKey();