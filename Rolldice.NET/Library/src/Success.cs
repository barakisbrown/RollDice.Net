namespace Library
{
    /// <summary>
    /// Success Dice are for any games that use Success to determine an outcome.
    /// Ex. White Wolf / Shadowrun / Savage Worlds
    /// </summary>
    public class Success : Dice
    {
        private readonly int _targetNumber;

        public Success(DiceTypes type, int targetNumber)
        {
            Die = type;
            _targetNumber = targetNumber;
            Initialize();
        }

        /// <summary>
        /// Take the Die and rolls it. Compares it to a TN.
        /// If it equal or greater than, we have a winner
        /// </summary>
        /// <returns>1 for Success / 0 for Failure</returns>
        public override int RollDie()
        {
            var diceRolled = RollDie(Die);

            return (diceRolled >= _targetNumber) ? 1 : 0;
        }
    }
}