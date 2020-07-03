using System;

namespace CryptographersConundrum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cryptographer's Conundrum
            // https://open.kattis.com/problems/conundrum
            // simple numerical program

            var myText = EnterYourText();
            var res = GiveDays(myText);
            Console.WriteLine(res);
        }
        private static int GiveDays(string yourText)
        {
            int sum = 0;
            for (int i = 0; i < yourText.Length; i++)
            {
                if (TextCharCond(yourText[i], i)==true) // this char != {'P', 'E', 'R'}
                    sum = sum + 1;
            }
            return sum;
        }
        private static bool TextCharCond(char a, int index)
        {
            if (a != 'P' && index%3==0)
                return true;
            else if (a != 'E' && index % 3 == 1)
                return true;
            else if (a != 'R' && index % 3 == 2)
                return true;
            else
                return false;
        }
        private static string EnterYourText()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                if (TextCond(str) == false)
                    throw new FormatException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterYourText();
            }
            return str;
        }
        private static bool TextCond(string str)
        {
            int strLeng = str.Length;
            if (strLeng < 3 || strLeng > 300 || strLeng % 3 != 0)
                return false;
            for (int i = 0; i < strLeng; i++)
            {
                if (char.IsUpper(str[i]) == false)
                    return false;
            }
            return true;
        }
    }
}
