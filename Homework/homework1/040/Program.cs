using System;

namespace Task040
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("enter your string: ");
            string usersString = Console.ReadLine();

            ToLowerCase(usersString);
            Console.ReadKey();
        }

        public static void ToLowerCase(string usersString)
        {
            char[] usersCharFromStringArray = usersString.ToCharArray();

            for (int i = 0; i < usersCharFromStringArray.Length; i++)
            {
                bool isUpperCaseChar = (usersCharFromStringArray[i] >= 40 && usersCharFromStringArray[i] <= 90) ||
                                       (usersCharFromStringArray[i] >= 1040 && usersCharFromStringArray[i] <= 1071);
                if (isUpperCaseChar)
                {
                    usersCharFromStringArray[i] = (char)(usersCharFromStringArray[i] + 32);
                }
            }

            Console.Write("LowerCase string : ");
            foreach (var item in usersCharFromStringArray)
            {
                Console.Write((char)item);
            }
        }
    }
}
