using System;

namespace Library
{
    /// <summary>
    /// This is what a typical die would represent.
    /// Therefore this would be used if the results
    /// rolled do not have to worry about it exploding
    /// or not.
    /// </summary>
    public class Regular : Dice
    {
        /// <summary>
        /// Constructor for this object
        /// </summary>
        /// <param name="die">Enum type describing which type of Die this represents</param>
        public Regular(DiceTypes die)
        {
            Die = die;
            Sides = Die.ConvertToInt();
            Initialize();
        }

        /// <summary>
        /// Implementation of the abstract RollDie method which in turns call the concrete
        /// RollDie method defined in the base class.
        /// </summary>
        /// <returns>Integer of the Rolled Dice in question .. [1..N]</returns>
        public override int RollDie()
        {
            if (Die == DiceTypes.None)
                throw new ArgumentException("It has been initialized properly yet.");
            return RollDie(Die);
        }
    }
}