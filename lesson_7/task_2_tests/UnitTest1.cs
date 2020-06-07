using NUnit.Framework;
using task_2;

namespace task_2_tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, Delegates.myDel(1, 2, "!"));
            Assert.AreEqual(0, Delegates.myDel(1, 2, "?"));
            Assert.AreEqual(0, Delegates.myDel(1, 2, "+"));
            Assert.AreEqual(0, Delegates.myDel(1, 2, "-"));
            
            Assert.AreEqual(2, Delegates.myDel(1, 2, "*"));
            Assert.AreEqual(6, Delegates.myDel(3, 2, "*"));
            Assert.AreEqual(10, Delegates.myDel(5, 2, "*"));
            
            Assert.AreEqual(1, Delegates.myDel(2, 2, "/"));
            Assert.AreEqual(2, Delegates.myDel(4, 2, "/"));
            Assert.AreEqual(3, Delegates.myDel(6, 2, "/"));
        }
    }
}