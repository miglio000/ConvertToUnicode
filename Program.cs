using System;

namespace ConvertToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Insert a code to get the symbol: ");
            string unicodeString = Console.ReadLine();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
            
        }
    }
}
