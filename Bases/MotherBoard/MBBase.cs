using EB.Game.Components.Bases.MotherBoard;
using EB.Game.Components.CPU;

namespace EB.Game.Components
{
    public class MBBase
    {
        public SATABase[] Sata;
        public SOCKETBase Socket;
        public int MaxRAMSize;
        public RAMBase[] RAM;
        public string MBName;
        public CPUBase Cpu;
        public MBBase(SATABase[] sata, SOCKETBase socket, int maxRAMSize, RAMBase[] rAM, string mBName)
        {
            Sata = sata;
            Socket = socket;
            MaxRAMSize = maxRAMSize;
            RAM = rAM;
            MBName = mBName;
            Cpu = new CPUBase();
        }
        public MBBase() { }
    }
}
