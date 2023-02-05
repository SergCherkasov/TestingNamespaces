using System.Runtime.CompilerServices;
using TestingNamespaces.Add;

namespace TestsForAdding
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Add add=new Add();
            int x = 2;
            int y=3;
            int res=add.Adding(x, y);
            Assert.AreEqual(res,5);
        }
    }
}