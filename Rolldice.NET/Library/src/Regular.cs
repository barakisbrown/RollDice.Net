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
        public override int RollDie()
        {
            throw new System.NotImplementedException();
        }
    }
}