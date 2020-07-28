using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void PalindromTest_Racecar()
        {
            Assert.AreEqual(true, Palindrome.IsPalindrome("racecar"));
        }
        [TestMethod]
        public void PalindromTest_palindrome()
        {
            Assert.AreEqual(false, Palindrome.IsPalindrome("palindrome"));
        }
        [TestMethod]
        public void PalindromTest_Gustavo()
        {
            Assert.AreEqual(false, Palindrome.IsPalindrome("Gustavo"));
        }
        [TestMethod]
        public void PalindromTest_Bob()
        {
            Assert.AreEqual(true, Palindrome.IsPalindrome("Bob"));
        }
    }
}
