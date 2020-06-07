using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using lesson_7;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Delegates.myDel(new int[] { 4, 0, 0, 0 }) );
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Delegates.myDel(new int[] { 0, 6, 1, 1 }) );
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(3, Delegates.myDel(new int[] { 9, 1, 1, 1 }) );
        }
        
        [Test]
        public void Test4()
        {
            Assert.AreEqual(4, Delegates.myDel(new int[] { 3, 1, 12, 0 }) );
        }
        
        [Test]
        public void Test5()
        {
            Assert.AreEqual(5, Delegates.myDel(new int[] { 15, 1, 3, 1 }) );
        }
        
        [Test]
        public void Test6()
        {
            Assert.AreEqual(6, Delegates.myDel(new int[] { 4, 1, 1, 18 }) );
        }
        
        [Test]
        public void Test7()
        {
            Assert.AreEqual(7, Delegates.myDel(new int[] { 5, 1, 1, 21 }) );
        }
        
        [Test]
        public void Test8()
        {
            Assert.AreEqual(8, Delegates.myDel(new int[] { 12, 12, 1, 7 }) );
        }
        
        [Test]
        public void Test9()
        {
            Assert.AreEqual(9, Delegates.myDel(new int[] { 27, 4, 1, 4 }) );
        }
        
        [Test]
        public void Test10()
        {
            Assert.AreEqual(10, Delegates.myDel(new int[] { 2, 6, 16, 16 }) );
        }

    }
    
}