using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string list = "running, learn, swimming, jumping, standing, play, walking, talking, write, read";

            string pattern = @"\b\w+ing\b";

            MatchCollection matches = Regex.Matches(list, pattern);

            string wordsList = "Список слов с окончанием 'ing': ";
            foreach (Match match in matches)
            {
                wordsList += match.Value + ", ";
            }
            Console.WriteLine(wordsList.TrimEnd(',', ' '));
        }
    }
}
