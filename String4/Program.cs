using System;
using System.Text;
//Implement a method to perform a basic string compression using the counts of repeated characters.
namespace String4
{
    class Program
    {
        /*
         * For example, the string aabccccaaa would become a2b1c4a3.
         * If the compressed string would not become smaller than the original string, 
         * your method should return the original string.
         * */
        static string Compress(string expr)
        {
            if (!IsSmaller(expr))
                return expr;
            StringBuilder sbuild = new StringBuilder();
            char letter = expr[0];
            int count = 1;
            for (int i = 1; i < expr.Length; i++)
            {
                if (letter != expr[i])
                {
                    sbuild.Append(letter);
                    sbuild.Append(count);
                    letter = expr[i];
                    count = 1;
                }
                else
                    count++;
            }
            sbuild.Append(letter);
            sbuild.Append(count);
            return sbuild.ToString();
        }

        static bool IsSmaller(string expr)
        {
            char letter = expr[0];
            int count = 1;
            for (int i = 1; i < expr.Length; i++)
            {
                if (letter != expr[i])
                {
                    count++;
                    letter = expr[i];
                }
            }
            if (count * 2 >= expr.Length)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            string str = "abbbcccaa"; //a1b2c3a2
            str = Compress(str);
            Console.WriteLine(str);
        }
    }
}
