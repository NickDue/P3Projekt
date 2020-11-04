namespace Server
{
    public class PicklistLine
    {
        public int plProductID;
        public int plAmount;
        public string plProductName;
        public int plVolume;
        public int plWeight;
        public int plPlacement;

        public PicklistLine(int plProductID, int plAmount, string plProductName, int plVolume, int plWeight, int plPlacement)
        {
            this.plProductID = plProductID;
            this.plAmount = plAmount;
            this.plProductName = plProductName;
            this.plVolume = plVolume;
            this.plWeight = plWeight;
            this.plPlacement = plPlacement;
        }
    }
}
