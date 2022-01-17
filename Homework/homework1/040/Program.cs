using System;

namespace Task040
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your string: ");
            string usersString = Console.ReadLine();

            ToLowerCase(usersString);
            Console.ReadKey();
        }

        public static void ToLowerCase(string usersString)
        {
            char[] usersCharFromStringArray = usersString.ToCharArray();
            int[] usersIntFromStringArray = new int[usersCharFromStringArray.Length];
            for (int i = 0; i < usersCharFromStringArray.Length; i++)
            {
                usersIntFromStringArray[i] = usersCharFromStringArray[i];
            }

            for (int j = 0; j < usersIntFromStringArray.Length; j++)
            {
                if (usersIntFromStringArray[j] < 97)
                {
                    usersIntFromStringArray[j] = usersIntFromStringArray[j] + 32;
                }
            }

            Console.WriteLine("LowerCase String: ");
            foreach (var item in usersIntFromStringArray)
            {
                Console.Write((char)item);
            }
        }
    }
}
