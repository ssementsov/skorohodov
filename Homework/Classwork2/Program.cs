// Создайте переменную типа float и поместите в нее число, равное 2,7182818284590452.

System.Single s = 2.7182818284590452F;
Console.WriteLine($"float is {s}\n");

System.Byte b = (System.Byte)s;
Console.WriteLine($"byte is {b}\n");

System.SByte sb = (System.SByte)s;
Console.WriteLine($"sbyte is {sb}\n");

System.Int16 i = (System.Int16)s;
Console.WriteLine($"short is {i}\n");

System.UInt16 ui = (System.UInt16)s;
Console.WriteLine($"ushort is {ui}\n");

System.Int32 ii = (System.Int32)s;
Console.WriteLine($"int is {ii}\n");

System.UInt32 uii = (System.UInt32)s;
Console.WriteLine($"uint is {uii}\n");

System.Int64 l = (System.Int64)s;
Console.WriteLine($"long is {l}\n");

System.UInt64 ul = (System.UInt64)s;
System.Console.WriteLine($"ulong is {ul}\n");

System.Double d = (System.Double)s;
Console.WriteLine($"double is {d}\n");

System.Decimal dc = (System.Decimal)s;
Console.WriteLine($"decimal is {dc}\n");

Console.ReadKey();