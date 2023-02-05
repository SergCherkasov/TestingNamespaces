using TestingNamespaces.Add;

namespace TestsForAdding
{
    [TestClass]
    public class TestAdding
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