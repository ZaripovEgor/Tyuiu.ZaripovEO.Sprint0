using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint0.Task2.Lib;

using Tyuiu.ZaripovEO.Sprint0.Task2.Lib;
namespace Tyuiu.ZaripovEO.Sprint0.Task2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Егор", res);
        }
    }
}
