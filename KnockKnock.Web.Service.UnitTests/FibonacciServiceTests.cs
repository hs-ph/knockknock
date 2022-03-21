using System;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using KnockKnock.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Web.Service.UnitTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class FibonacciServiceTests
    {
        [TestMethod]
        public void Fibonacci_Zero_ShouldReturnZero()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("0");
            Assert.AreEqual(0,actual);
        }

        [TestMethod]
        public void Fibonacci_One_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("1");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Fibonacci_Two_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("2");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Fibonacci_Three_ShouldReturnTwo()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("3");
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Fibonacci_Four_ShouldReturn3()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("4");
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Fibonacci_Five_ShouldReturn5()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("5");
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Fibonacci_Six_ShouldReturn5()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("6");
            Assert.AreEqual(8, actual);
        }
        
        [TestMethod]
        public void Fibonacci_Seven_ShouldReturn13()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("7");
            Assert.AreEqual(13, actual);
        }
        
        [TestMethod]
        public void Fibonacci_Eight_ShouldReturn21()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("8");
            Assert.AreEqual(21, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus1_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-1");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus2_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-2");
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus3_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-3");
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus4_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-4");
            Assert.AreEqual(-3, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus5_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-5");
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus6_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-6");
            Assert.AreEqual(-8, actual);
        }
        
        [TestMethod]
        public void Fibonacci_Minus7_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-7");
            Assert.AreEqual(13, actual);
        }

        [TestMethod]
        public void Fibonacci_Minus8_ShouldReturnOne()
        {
            var fibonacciService = new FibonacciService();
            var actual = fibonacciService.Calculate("-8");
            Assert.AreEqual(-21, actual);
        }

        [TestMethod]
        public void Fibonacci_MinusLargeNumber_ShouldReturnOutOfRangeException()
        {
            var fibonacciService = new FibonacciService();
            Action act = () => fibonacciService.Calculate("-93");
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void Fibonacci_PositiveLargeNumber_ShouldReturnOutOfRangeException()
        {
            var fibonacciService = new FibonacciService();
            Action act = () => fibonacciService.Calculate("93");
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
