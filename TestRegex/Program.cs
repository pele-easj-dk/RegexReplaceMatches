using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace TestRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "Two swindlers arrive at the capital city of an emperor " +
                          "who spends lavishly on clothing at the expense of state matters. " +
                          "Posing as weavers, they offer to supply him with magnificent clothes " +
                          "that are invisible to those who are stupid or incompetent. " +
                          "The emperor hires them, and they set up looms and go to work. " +
                          "A succession of officials, and then the emperor himself, " +
                          "visit them to check their progress. Each sees that the looms are empty " +
                          "but pretends otherwise to avoid being thought a fool. " +
                          "Finally, the weavers report that the emperor's suit is finished. " +
                          "They mime dressing him and he sets off in a procession before the whole city. " +
                          "The townsfolk uncomfortably go along with the pretense, " +
                          "not wanting to appear inept or stupid, until a child blurts out " +
                          "that the emperor is wearing nothing at all. " +
                          "The people then realize that everyone has been fooled. " +
                          "Although startled, the emperor continues the procession, " +
                          "walking more proudly than ever.";


            // opgave a 
            String patternA = "[Ee]mperor";
            Regex regex = new Regex(patternA);

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine("Emperor at ix: " + match.Index);
            }

            // opgave b 
            String patternB = @"([a-zA-Z, ]+\.)";
            regex = new Regex(patternB);

            MatchCollection matchesb = regex.Matches(text);
            foreach (Match m in matchesb)
            {
                Console.WriteLine("New sentence");
                Console.WriteLine(m.Captures[0]);
            }

            // opgave C 
            String patternC = "[Ee]mperor";
            regex = new Regex(patternC);
            String rText = regex.Replace(text, "teacher");
            Console.WriteLine("");
            Console.WriteLine("Replaced text");
            Console.WriteLine(rText);

            Console.ReadLine();
        }
    }
}
