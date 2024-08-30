using NUnit.Framework;
using Text;

namespace Text.Tests{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void willItTrue()
        {
            bool result = Str.IsPalindrome("racecar");
            Assert.That(result == true);
        }
        
        [Test]
        public void willItTrue_cap()
        {
            bool result = Str.IsPalindrome("Racecar");
            Assert.That(result == true);
        }
        
        [Test]
        public void willItFlase()
        {
            bool result = Str.IsPalindrome("Hello");
            Assert.That(result == false);
        }
    }
}