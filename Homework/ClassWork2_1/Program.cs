// рассчёты с x, y, z;

int x = 10, y = 12, z = 3;

Console.WriteLine($"Result case 1 = {x += y - x++ * z}\n");

Console.WriteLine($"Result case 2 = {z = --x - y * 5}\n");

Console.WriteLine($"Result case 3 = {y /= x + 5 % z}\n");

Console.WriteLine($"Result case 4 = {z = x++ + y * 5}\n");

Console.WriteLine($"Result case 5 = {x = y - x++ * z}\n");

Console.ReadKey();