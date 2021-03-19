using System;
using Xunit;

namespace CodingTest
{
    public class StringTests
    {
        [Theory]
        [InlineData("We test coder. Give us a try?", 4)]
        [InlineData("This is a sentence of seven words! This one has five words.", 7)]
        [InlineData("Only three here.", 3)]
        public void Returns_The_Highest_Number_Of_Words_Of_A_Sentence(string S, int expectedResult)
        {
            var sentences = S.Split(new string[] { ".", "!", "?" }, StringSplitOptions.None);
            var result = 0;

            foreach (var sentence in sentences)
            {
                var nbWords = sentence.Split(' ').Length;

                if (sentence.StartsWith(" "))
                    nbWords--;

                if (nbWords > result)
                    result = nbWords;
            }

            Assert.Equal(expectedResult, result);
        }
    }
}
