using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcConsole;

namespace TestCalcConsole
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //arrange
            var x = 10;
            var y = 1;
            var calc = new Calc();

            //act           
            var result = calc.Sum(x,y);
            //assert
            Assert.AreEqual(result,11);
        }
        [TestMethod]
        public void TestSub()
        {
            //arrange
            var x = 10;
            var y = 1;
            var calc = new Calc();

            //act           
            var result = calc.Sub(x, y);
            //assert
            Assert.AreEqual(result, 9);
        }
        [TestMethod]
        public void TestMulti()
        {
            //arrange
            var x = 10;
            var y = 2;
            var calc = new Calc();

            //act           
            var result = calc.Multi(x, y);
            //assert
            Assert.AreEqual(result, 20);
        }
        [TestMethod]
        public void TestDiv()
        {
            //arrange
            var x = 10;
            var y = 2;
            var calc = new Calc();

            //act          
            var result = calc.Div(x, y);
            //assert
            Assert.AreEqual(result, 5);
        }
        [TestMethod]
        public void TestSqrt()
        {
            //arrange
            var x = 25;           
            var calc = new Calc();

            //act            
            var result = calc.Sqrt(x);
            //assert
            Assert.AreEqual(result, 5);
        }
        [TestMethod]
        public void TestPow()
        {
            //arrange
            var x = 5;
            var y = 2;
            var calc = new Calc();

            //act            
            var result = calc.Pow(x,y);
            //assert
            Assert.AreEqual(result, 25);
        }
    }   
}
