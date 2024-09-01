using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test_NullString()
        {
            Assert.That(Str.UniqueChar(null), Is.EqualTo(-1));
        }

        [Test]
        public void Test_EmptyString()
        {
            Assert.That(Str.UniqueChar(""), Is.EqualTo(-1));
        }

        [Test]
        public void Test_SingleCharacterString()
        {
            Assert.That(Str.UniqueChar("a"), Is.EqualTo(0));
        }

        [Test]
        public void Test_FirstCharacterUnique()
        {
            Assert.That(Str.UniqueChar("abc"), Is.EqualTo(0));
        }

        [Test]
        public void Test_MiddleCharacterUnique()
        {
            Assert.That(Str.UniqueChar("aabbcddee"), Is.EqualTo(4));
        }

        [Test]
        public void Test_LastCharacterUnique()
        {
            Assert.That(Str.UniqueChar("aabbcce"), Is.EqualTo(6));
        }

        [Test]
        public void Test_NoUniqueCharacter()
        {
            Assert.That(Str.UniqueChar("aabbcc"), Is.EqualTo(-1));
        }
    }
}