using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimplePAI.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get();
            Assert.Equal("Tuanph", returnValue);
        }
    }
}
