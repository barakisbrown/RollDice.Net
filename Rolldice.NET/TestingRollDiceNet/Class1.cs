using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingRollDiceNet
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2,2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2,2));
        }

        [Theory]
        [InlineData((3))]
        [InlineData((5))]
        [InlineData((6))]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        private int Add(int x, int y)
        {
            return x + y;
        }

        private bool IsOdd(int value) => value % 2 == 1;
    }
}
