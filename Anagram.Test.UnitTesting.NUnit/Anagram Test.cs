namespace Anagram.Test.UnitTesting.NUnit
{
    public class Tests
    {
        [TestCase("!abc123", ExpectedResult = "!cba123")]
        [TestCase("abc123 qwerty", ExpectedResult = "cba123 ytrewq")]
        [TestCase(" abc123  qwerty", ExpectedResult = " cba123  ytrewq")]
        public string Anagram_Sentence_ReverseSentence(string sentence)
        {
            return Anagram.Reverse(sentence);
        }

        [TestCase(null)]
        [TestCase(Anagram.emptyString)]
        [TestCase(Anagram.whiteSpace)]
        public void Anagram_InvalidValue_ArgumentException(string? word)
        {
            Assert.Throws<ArgumentException>(() => Anagram.Reverse(word));
        }
    }
}