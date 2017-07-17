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
        private int _explodTargetNumber;

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
        }

        public override int RollDie()
        {
            throw new System.NotImplementedException();
        }
    }
}