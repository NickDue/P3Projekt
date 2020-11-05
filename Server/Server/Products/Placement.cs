namespace Server
{
    public class Placement
    {
        public string section; //H2
        public string subSection; //row
        public int level; //højde

        public Placement(string section, string subSection, int level)
        {
            this.section = section;
            this.subSection = subSection;
            this.level = level;
        }

        public string PrintPlacement()
        {
            return section + "-" + subSection + "-" + level;
        }
    }
}
