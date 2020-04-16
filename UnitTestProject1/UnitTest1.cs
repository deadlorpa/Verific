using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // ����� �� ����� �������
        [TestMethod]
        public void TestOtrezokInit() // �������������
        {
            double x1 = 0, x2 = 0, y1 = 1, y2 = 2;
            otrezok a = new otrezok();
            a.Init(x1, y1, x2, y2);
            Assert.AreEqual(x1, a.getx1());
            Assert.AreEqual(y1, a.gety1());
            Assert.AreEqual(x2, a.getx2());
            Assert.AreEqual(y2, a.gety2());
        }

        [TestMethod]
        public void TestOtrezokDlina() // ����� �������
        {
            double x1 = 0, x2 = 0, y1 = 1, y2 = 2;
            // ����� �������, ����������, ����� 1
            double dlina = 1;
            otrezok a = new otrezok();
            a.Init(x1, y1, x2, y2);
            Assert.AreEqual(dlina, a.dlina_otreazka());
        }

        // ����� �� ����� XOY
        [TestMethod]
        public void TestXOYInit() // �������������
        {

            double x1 = 0, x2 = 0, y1 = 1, y2 = 2, z = 1;
            xoy a = new xoy();
            a.Init(x1, y1, x2, y2, z);
            Assert.AreEqual(x1, a.getx1());
            Assert.AreEqual(y1, a.gety1());
            Assert.AreEqual(x2, a.getx2());
            Assert.AreEqual(y2, a.gety2());
            Assert.AreEqual(z, a.getz());
        }

        [TestMethod]
        public void TestXOYDlina() // ����� �������
        {

            double x1 = 0, x2 = 0, y1 = 1, y2 = 2, z = 1;
            // ����� ������� ���������� 2
            double dlina = 2;
            xoy a = new xoy();
            a.Init(x1, y1, x2, y2, z);
            Assert.AreEqual(dlina, a.dlina_otreazka());
        }

        [TestMethod]
        public void TestXOYDisplay() // �������
        {
            double x1 = 0, x2 = 0, y1 = 1, y2 = 2, z = 1;
            xoy a = new xoy();
            a.Init(x1, y1, x2, y2, z);
            Assert.IsTrue(a.Display());
        }
    }
}
