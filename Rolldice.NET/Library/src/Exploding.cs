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
        public override int RollDie()
        {
            throw new System.NotImplementedException();
        }
    }
}