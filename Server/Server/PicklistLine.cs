namespace Server
{
    public class PicklistLine
    {
        public int _plProductID;
        public int _plAmount;
        public string _plProductName;
        public int _plVolume;
        public int _plWeight;
        public int _plPlacement;

        public PicklistLine(int plProductID, int plAmount, string plProductName, int plVolume, int plWeight, int plPlacement)
        {
            this._plProductID = plProductID;
            this._plAmount = plAmount;
            this._plProductName = plProductName;
            this._plVolume = plVolume;
            this._plWeight = plWeight;
            this._plPlacement = plPlacement;
        }
    }
}
