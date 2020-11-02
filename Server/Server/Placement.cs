namespace Server
{
    public class Placement
    {
        public int _section;
        public int _subSection;
        public int _area;
        public int _level;

        public Placement(int section, int subSection, int area, int level)
        {
            this._section = section;
            this._subSection = subSection;
            this._area = area;
            this._level = level;
        }
    }
}
