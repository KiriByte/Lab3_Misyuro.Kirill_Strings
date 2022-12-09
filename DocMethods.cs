using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Misyuro.Kirill_Strings
{
    internal class DocMethods
    {
        public string GetFirstNumbers(string str)
        {
            string[] substr = str.Split("-");
            return substr[0] + " " + substr[2];
        }

        public StringBuilder ReplaceChars(string str)
        {
            string[] substr = str.Split("-");
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < substr.Length; i++)
            {
                if (substr[i].Length == 3)
                {
                    result.Append("***");
                }
                else
                {
                    result.Append(substr[i]);
                }
                result.Append('-');
            }
            return result.Remove(result.Length - 1, 1);
        }

        public StringBuilder OnlyLettersLowerCase(string str)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder result2 = new StringBuilder();
            string[] substr = str.Split("-");
            result.Append(substr[1].Substring(0, substr[1].Length).ToLower()).Append("/");
            result.Append(substr[3].Substring(0, substr[3].Length).ToLower()).Append("/");
            foreach (char s in substr[4])
            {
                if (Char.IsLetter(s))
                {
                    result.Append(Char.ToLower(s)).Append("/");
                }
            }
            result.Remove(result.Length - 1, 1);
            return result;
        }

        public StringBuilder OnlyLettersUpperCase(string str)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder result2 = new StringBuilder();
            string[] substr = str.Split("-");
            result.Append(substr[1].Substring(0, substr[1].Length).ToUpper()).Append("/");
            result.Append(substr[3].Substring(0, substr[3].Length).ToUpper()).Append("/");
            foreach (char s in substr[4])
            {
                if (Char.IsLetter(s))
                {
                    result.Append(Char.ToUpper(s)).Append("/");
                }
            }
            result.Remove(result.Length - 1, 1);
            return result;
        }

        public string SearchLetters(string str)
        {
            string[] substr = str.Split('-');
            if (substr[1].ToLower() == "abc" || substr[3].ToLower() == "abc")
            {
                return "The string contains the sequence";
            }
            else return "The string does not contain sequence";
        }

        public string SearchStartNumbers(string str)
        {
            if (str.StartsWith("555"))
            {
                return "Documetn start with 555";
            }
            else return "Document does not start with 555 ";
        }

        public string SearchEndNumbers(string str)
        {
            if (str.EndsWith("1a2b"))
            {
                return "Documetn end with 1a2b";
            }
            else return "Document does not end with 1a2b ";
        }

    }
}
