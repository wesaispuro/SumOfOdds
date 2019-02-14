using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcOddTest()
        {
            Assert.AreEqual(9, Program.CalcOdd(6));
        }
    }
}