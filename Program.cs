using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab3_Misyuro.Kirill_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program mc = new Program();
            DocMethods dm = new DocMethods();
            // xxxx - yyy - xxxx - yyy - xyxy
            string input = "5555-ABc-5678-dEF-1a2B";
            Console.WriteLine(input);
            Console.WriteLine(dm.GetFirstNumbers(input));
            Console.WriteLine(dm.ReplaceChars(input));
            Console.WriteLine(dm.OnlyLettersLowerCase(input));
            Console.WriteLine(dm.OnlyLettersUpperCase(input));
            Console.WriteLine(dm.SearchLetters(input));
            Console.WriteLine(dm.SearchStartNumbers(input));
            Console.WriteLine(dm.SearchEndNumbers(input));
        }


    }
}