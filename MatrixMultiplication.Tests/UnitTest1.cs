using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MatrixMultiplication.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMultiplicationMatrixCreation()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("3\n4\n"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[0]);

                    string expected = "Матрица умножения:\r\n" +
                                      "1\t2\t3\t\r\n" +
                                      "2\t4\t6\t\r\n" +
                                      "3\t6\t9\t\r\n" +
                                      "4\t8\t12\t\r\n";

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("a\nb\n"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[0]);

                    string expected = "Некорректный ввод. Пожалуйста, введите целые числа.\r\n";

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [TestMethod]
        public void TestZeroInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("0\n0\n"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[0]);

                    string expected = "Числа должны быть больше нуля.\r\n";

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }
    }
}
