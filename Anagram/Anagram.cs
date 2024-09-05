using System.Text;

namespace Anagram
{
    public class Anagram
    {
        public const string whiteSpace = " ";
        public const string emptyString = "";
        public static string Reverse(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentException("Sentence cannot be null, empty or contain only spaces");
            }

            string[] words = sentence.Split(whiteSpace);

            StringBuilder newSentence = new StringBuilder();

            foreach (string word in words)
            {
                newSentence.Append(ReverseWord(word) + whiteSpace);
            }
            newSentence.Remove(newSentence.Length - 1, 1);

            return newSentence.ToString();
        }

        private static string ReverseWord(string word)
        {
            char[] newWord = new char[word.Length];
            string onlyLetters = string.Empty;
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    onlyLetters += (word[i]);
                }
                else
                {
                    newWord[i] = word[i];
                }
            }

            for (int i = 1; i <= word.Length; i++)
            {
                if (newWord[^i] == 0)
                {
                    newWord[^i] = onlyLetters[counter];
                    counter++;
                }
            }
            return new string(newWord);
        }
    }
}