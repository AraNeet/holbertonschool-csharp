using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("camel")]
        [TestCase("blooper")]
        [TestCase("a")]
        public void CamelCase_WhenOneWord_ReturnOne(string s)
        {
            int result = Str.CamelCase(s);

            Assert.That(result == 1);
        }

        [TestCase("camelCase", 2)]
        [TestCase("blooperReal", 2)]
        [TestCase("aDogAteMyHomework", 5)]     
        [TestCase("itIsMyOnlyRegretThatIHaveButOneLifeToLoseForMyCountry", 16)]
        public void CamelCase_WhenMultipleWords_ReturnsCorrectWordCount(string s, int expected)
        {

            int result = Str.CamelCase(s);

            Assert.That(result == expected);        
        }
        
        [TestCase("IO", 2)]
        [TestCase("Html", 1)]
        public void CamelCase_Acronyms_ReturnsCorrectWordCount(string s, int expected)
        {
            int result = Str.CamelCase(s);
            Assert.That(result == expected);
        }

        [TestCase("")]
        public void CamelCase_WhenEmptyString_ReturnZero(string s)
        {
            int result = Str.CamelCase(s);

            Assert.That(result == 0);
        }
    }
}