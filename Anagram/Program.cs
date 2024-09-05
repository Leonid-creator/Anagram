using System.Xml;

namespace Task1Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word or sentence: ");
            string sentence = Console.ReadLine();

            string reverseSentence = Anagram.Reverse(sentence);
            Console.WriteLine("Reversed: " + reverseSentence);

            Console.ReadLine();
        }
    }
}
