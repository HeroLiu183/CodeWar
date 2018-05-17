using System;
using System.Text;
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

            Assert.AreEqual(expect, result);
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
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void test()
        {
            var a = new StringBuilder();
            a.Append("123;");
            a.Append("123;");
            a.Append("123;");
            a.Append("123;");
            a.Append("123;");
            a.Append("113;");

            a.Remove(a.Length - 1, 1);
            Console.WriteLine(a.ToString());
        }

        [TestMethod]
        public void now()
        {
            var a = new Mytest();
            Console.WriteLine(a.q);
            Console.WriteLine(a.ba);
            a.ba = 100;
            a.q = 101;
            Console.WriteLine(a.q);
            a.k(1000);
        }
    }

    public class Mytest : Testk
    {
        public void k(int dd) => g8(dd);
        public override int q => ba;
        public int ba { get; set; }
    }

    public class Testk
    {
        public virtual void g8(int i)
        {
            Console.WriteLine(i);
        }
        private int temp = 99;
        public virtual int q {
            get { return temp; }
            set { temp = value; }
        }
    }
}