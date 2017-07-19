using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Xunit;

namespace TestingRollDiceNet
{
    public class TestClass
    {
        [Theory]
        [InlineData(DiceTypes.D6)]
        [InlineData(DiceTypes.D10)]
        public void TestRegularDice(DiceTypes value)
        {
            var Dice = new Regular(value);

            Assert.InRange(Dice.RollDie(),1,value.ConvertToInt());
        }

        [Fact]
        public void TestWrongDiceType()
        {
            var TestDice = Extensions.ConvertToTypes(5);
            Assert.Equal(DiceTypes.None,TestDice);
        }
    }
}
