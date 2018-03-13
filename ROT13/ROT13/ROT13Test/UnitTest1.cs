using Encoder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ROT13Test
{
    [TestClass]
    public class RotTests
    {
        private readonly EncodeHelper _encodeHelper = new EncodeHelper();

        [TestMethod]
        public void AtoN()
        {
            var result = _encodeHelper.ROTEncode("a");
            var expect = "n";

            Assert.AreEqual(expect,result);
        }

        [TestMethod]
        public void notCovertIntAndSpace()
        {
            var result = _encodeHelper.ROTEncode("12 R");
            var expect = "12 E";

            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void FullStringEode()
        {
            var result = _encodeHelper.ROTEncode("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
            var expect = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
            Assert.AreEqual(expect,result);
        }
    }
}
