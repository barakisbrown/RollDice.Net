namespace Library
{
    /// <summary>
    /// Which dice that are allowed to be used
    /// For example, D3,D4,etc
    /// </summary>
    public enum DiceTypes
    {
        None,
        D3 = 3,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100
    }

    /// <summary>
    /// Static Class to house my extension method for me to test weather a certain type is allowed or not
    /// </summary>
    public static class Extensions
    {
        public static bool Allowed(this DiceTypes type)
        {
            bool retValue = false;
            switch (type)
            {
                case DiceTypes.None:
                    break;
                case DiceTypes.D3:
                case DiceTypes.D4:
                case DiceTypes.D6:
                case DiceTypes.D8:
                case DiceTypes.D10:
                case DiceTypes.D12:
                case DiceTypes.D20:
                case DiceTypes.D100:
                {
                    retValue = true;
                    break;
                }
            }

            return retValue;
        }     
    }
}