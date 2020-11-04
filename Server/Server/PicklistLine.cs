namespace Server
{
    public class PicklistLine
    {
        public int plProductID;
        public int plAmount;
        public string plProductName;
        public double plVolume;
        public double plWeight;
        public string plPlacement;

        public PicklistLine(int plProductID, int plAmount, string plProductName, double plVolume, double plWeight, string plPlacement)
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
