using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "bella roller label";
            Regex reg = new Regex(@"\w+(-\w+)*");

            var words = reg.Matches(txt).Cast<Match>().Select(i => i.Value).ToArray();
            foreach (var w in words)
            {
                Console.WriteLine(w);
                HashSet<char> hs = new HashSet<char>(w.ToLower());
                Console.WriteLine(string.Join(" ", hs));
                Console.WriteLine(new string('*', 6));
            }
            Console.ReadKey();
        }
    }
}
