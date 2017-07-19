namespace Library
{
    /// <summary>
    /// If a die has the ability to explode will explode
    /// only when the value rolled equals the max value 
    /// the dice can be rolled. It then rolls again until
    /// the next result does not equal the max value of 
    /// the die.
    /// </summary>
    public class Exploding : Dice
    {
        private readonly int _explodTargetNumber;

        /// <summary>
        /// Constructor needing what dice is rolled and what is the target number that is consider to explode
        /// or rolled again
        /// </summary>
        /// <param name="diceToBeRolled">Type of Dice to be Rolled</param>
        /// <param name="explodeTargetNumber">Value which a dice must equal or beat to explode(roll again)</param>
        public Exploding(DiceTypes diceToBeRolled, int explodeTargetNumber)
        {
            Die = diceToBeRolled;
            Sides = Die.ConvertToInt();
            _explodTargetNumber = explodeTargetNumber;
            Initialize();
        }

        /// <summary>
        /// This assumes that your looking for dice that will explode(roll again) if its hits a certain number.
        /// Most games assume the largest number of the die possible(D6 => 6) but I made it where you can decide
        /// differently
        /// </summary>
        /// <returns>returns the value of the total rolled(if its rolled again)</returns>
        public override int RollDie()
        {
            var result = RollDie(Die);
            var totalRolled = 0;

            if (result != _explodTargetNumber)
                return result;
            else
            {
                do
                {
                    totalRolled += result;
                    result = RollDie(Die);
                } while (result == _explodTargetNumber);

                totalRolled += result;
            }

            return totalRolled;
        }
    }
}