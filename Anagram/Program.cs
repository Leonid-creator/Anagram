using System.Xml;

namespace Anagram
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter word or sentence: ");
            string sentence = Console.ReadLine();

            string reverseSentence = Anagram.Reverse(sentence);
            Console.WriteLine("Reversed: " + reverseSentence);

            Console.ReadLine();
        }
    }
}
