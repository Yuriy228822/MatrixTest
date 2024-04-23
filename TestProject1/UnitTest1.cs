using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidInput_NonInteger()
        {
            // Arrange
            var input = new StringReader("a\nb\n");
            Console.SetIn(input);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[0]);

            // Assert
            var expectedOutput = "¬ведите два целых числа:\r\nќшибка: ¬ведите корректные целые числа.\r\n";
            Assert.AreEqual(expectedOutput, output.ToString());
        }
    }
}
