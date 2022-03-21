using System.Diagnostics.CodeAnalysis;
using KnockKnock.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Web.Service.UnitTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TriangleServiceTests
    {

        [TestMethod]
        public void TriangleType_InvalidSides_ReturnsError()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(0, 1, 1);
            Assert.AreEqual("error", actual);
        }


        [TestMethod]
        public void TriangleType_InvalidNegativeSides_ReturnsError()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(1, -1, 1);
            Assert.AreEqual("error", actual);
        }

        [TestMethod]
        public void TriangleType_SameSideLengths_ReturnsEquilateral()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(1, 1, 1);
            Assert.AreEqual("Equilateral", actual);
        }
        
        [TestMethod]
        public void TriangleType_Same2SideLengths_ReturnsIsosceles()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(3, 5, 5);
            Assert.AreEqual("Isosceles", actual);
        }

        [TestMethod]
        public void TriangleType_SameSideLengths_ReturnsScalene()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(4, 5, 3);
            Assert.AreEqual("Scalene", actual);
        }

        [TestMethod]
        public void TriangleType_InvalidTriangleSideLengths_ReturnsError()
        {
            var triangleService = new TriangleService();
            var actual = triangleService.GetTriangleType(4, 4, 9);
            Assert.AreEqual("error", actual);
        }
    }
}