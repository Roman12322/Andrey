using NUnit.Framework;
using static ��������.Form2;
using static ��������.Form2.PolybiusSquare;

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
            Assert.AreEqual("��v�K�nzKr�Kr", result);
        }
        [Test]
        public void Test2()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("privet medved", "");
            Assert.AreEqual("��u�q�lyqp�qp", result);
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
            Assert.AreEqual("��v�K�zKr�Kr", result);
        }
        [Test]
        public void Test5()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("��v�K�zKr�Kr", "key");
            Assert.AreEqual("privetmedved", result);
        }
        [Test]
        public void Test6()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("��v�K�zKr�Kr", "TUSUR");
            Assert.AreEqual("qsjwUunUfwUf", result);
        }
        [Test]
        public void Test7()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("� ������ ��������!", "���");
            Assert.AreEqual(".l������l�������,k", result);
        }
        [Test]
        public void Test8()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt(".l������l�������,k", "���");
            Assert.AreEqual("� ������ ��������!", result);
        }
    }
}