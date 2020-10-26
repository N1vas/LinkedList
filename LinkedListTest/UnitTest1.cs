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
    }
}
