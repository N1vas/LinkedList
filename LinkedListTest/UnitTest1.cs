using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProject;
namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchTest()
        {
            bool expected = true;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            bool result = list.Search(30);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InsertAfterValueTest()
        {
            bool expected = true;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAfterValue(30, 40);
            bool result = list.Search(40);
            Assert.AreEqual(expected, result);
        }
    }
}
