using System;

namespace Library
{
    /// <summary>
    /// This visualizes what a single die[example: D6] used in most board and roleplaying games
    /// </summary>
    public abstract class Dice
    {
        /// <summary>
        /// 
        /// </summary>
        private Random rand;

        /// <summary>
        /// Enum version of the type of die in question
        /// </summary>
        protected DiceTypes Die { get; set; } = DiceTypes.None;

        /// <summary>
        /// How many sides of the die [D6 => 6 is the sides]
        /// </summary>
        protected int Sides { get; set; }

        /// <summary>
        /// The amount on the die[D6 rolled would be a number between 1 .. 6]
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Generic function to Roll the above die
        /// </summary>
        /// <returns>what value was rolled</returns>
        public abstract int RollDie();

        /// <summary>
        /// Like RollDie, this specialized function with an input of DiceTypes
        /// will then roll that specific die and return it. Note, this method
        /// is already implemented since it is a speicialized version of the 
        /// method above.
        /// </summary>
        /// <param name="_dice">Dice to be rolled</param>
        /// <returns>returns 1..DiceType value</returns>
        public int RollDie(DiceTypes _dice)
        {
            if (_dice.Allowed())
            {               
                var result = rand.Next(1, _dice.ConvertToInt() + 1);

                Amount = result;
                return result;
            }
            throw new ArgumentException("_dice is not an allowed dice to be rolled");
        }

        public bool Initialize()
        {
            rand = new Random();
            return true;
        }
    }
}