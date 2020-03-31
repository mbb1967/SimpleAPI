using System;
using Xunit;
using SimpleAPI.Controllers;

namespace simpleapi.test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Mel Boulds", returnValue.Value);
        }
    }
}
