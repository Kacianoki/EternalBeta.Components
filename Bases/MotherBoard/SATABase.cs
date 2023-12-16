namespace EB.Game.Components.Bases.MotherBoard
{
    public class SATABase
    {
        public HDDBase HDD;
        public SSDBase SSD;
        public enum UseType
        {
            HDD,
            SSD,
            Empty
        }
        public UseType UsedBy;
        public SATABase(HDDBase HDD)
        {
            this.HDD = HDD;
            UsedBy = UseType.HDD;
        }
        public SATABase(SSDBase SSD)
        {
            this.SSD = SSD;
            UsedBy = UseType.SSD;
        }
        public SATABase()
        {
            UsedBy = UseType.Empty;
        }
    }
}
