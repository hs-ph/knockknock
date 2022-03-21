using System.Diagnostics.CodeAnalysis;
using KnockKnock.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Web.Service.UnitTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ReverseWordsServiceTests
    {
        [TestMethod]
        public void Reverse_NullString_ShouldReturnEmptyString()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse(null);

            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        public void Reverse_EmptyString_ShouldReturnEmptyString()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse("");

            Assert.AreEqual(string.Empty, actual);
        }
        
        [TestMethod]
        public void Reverse_SingleSpaceString_ShouldReturnEmptyString()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse(" ");

            Assert.AreEqual(" ", actual);
        }

        [TestMethod]
        public void Reverse_WordString_ShouldReturnReversedWord()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse("Lorem.");

            Assert.AreEqual(".meroL", actual);
        }

        [TestMethod]
        public void Reverse_ShortString_ShouldReturnReversedString()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse(
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse gravida at elit quis pretium.");

            Assert.AreEqual(
                "meroL muspi rolod tis ,tema rutetcesnoc gnicsipida .tile essidnepsuS adivarg ta tile siuq .muiterp",
                actual);
        }

        [TestMethod]
        public void Reverse_StringSpecialCharacters_ShouldReturnStringReversed()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse("P!u@n#c$t%u^a&t*i(o)n");

            Assert.AreEqual("n)o(i*t&a^u%t$c#n@u!P", actual);
        }

        [TestMethod]
        public void Reverse_SpacedOutCharactersCharacters_ShouldReturn()
        {
            var reverseWordsService = new ReverseWordsService();
            var actual = reverseWordsService.Reverse("  S  P  A  C  E  Y  ");

            Assert.AreEqual("  S  P  A  C  E  Y  ", actual);
        }
    }
}