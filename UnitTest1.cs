using NUnit.Framework;
using static ×åğíîâèê.Form2;
using static ×åğíîâèê.Form2.PolybiusSquare;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("privet medved", "key");
            Assert.AreEqual("âävçK¸nzKrçKr", result);
        }
        [Test]
        public void Test2()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("privet medved", "");
            Assert.AreEqual("áãuæqålyqpæqp", result);
        }
        [Test]
        public void Test3()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("", "key");
            Assert.AreEqual("", result);
        }
        [Test]
        public void Test4()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("privetmedved", "key");
            Assert.AreEqual("âävçK¸zKrçKr", result);
        }
        [Test]
        public void Test5()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("âävçK¸zKrçKr", "key");
            Assert.AreEqual("privetmedved", result);
        }
        [Test]
        public void Test6()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("âävçK¸zKrçKr", "TUSUR");
            Assert.AreEqual("qsjwUunUfwUf", result);
        }
        [Test]
        public void Test7()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("ß ÑÄÅËÀË ÊÓĞÑÎÂÓŞ!", "óğà");
            Assert.AreEqual(".lİÏĞ×Ë×lÖßÜİÚÍß,k", result);
        }
        [Test]
        public void Test8()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt(".lİÏĞ×Ë×lÖßÜİÚÍß,k", "óğà");
            Assert.AreEqual("ß ÑÄÅËÀË ÊÓĞÑÎÂÓŞ!", result);
        }
    }
}