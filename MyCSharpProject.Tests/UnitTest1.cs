namespace MyCSharpProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void TestString()
        {
            string str = "Hello";
            Assert.Equal("Hello", str);
        }
    }
}