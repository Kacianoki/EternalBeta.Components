using Newtonsoft.Json;

namespace EB.Game.Components.RAM
{
    public class DDRBase
    {
        public enum DDRType
        {
            DDR1,
            DDR2,
            DDR3,
            DDR4,
            DDR5
        }
        public int MaxNSR;
        public int MinTimeToRead;
        public int MinTimeToWrite;
        public int MinTimeToReWrite;
        public int MinTimeToFind;

        public int MaxTimeToRead;
        public int MaxTimeToWrite;
        public int MaxTimeToReWrite;
        public int MaxTimeToFind;
        [JsonProperty]
        public DDRType DDR;
        public DDRBase(DDRType ddr) 
        {
             DDR = ddr;
            if(ddr == DDRType.DDR1)
            {
                MaxNSR = 1;
                MinTimeToRead = 50;
                MinTimeToWrite = 100;
                MinTimeToReWrite = 150;
                MinTimeToFind = 30;

                MaxTimeToRead = 40;
                MaxTimeToWrite = 90;
                MaxTimeToReWrite = 140;
                MaxTimeToFind = 20;
            }
            if (ddr == DDRType.DDR2)
            {
                MaxNSR = 1;
                MinTimeToRead = 30;
                MinTimeToWrite = 50;
                MinTimeToReWrite = 60;
                MinTimeToFind = 15;

                MaxTimeToRead = 20;
                MaxTimeToWrite = 40;
                MaxTimeToReWrite = 50;
                MaxTimeToFind = 10;
            }
            if (ddr == DDRType.DDR3)
            {
                MaxNSR = 2;
                MinTimeToRead = 20;
                MinTimeToWrite = 20;
                MinTimeToReWrite = 25;
                MinTimeToFind = 5;

                MaxTimeToRead = 15;
                MaxTimeToWrite = 15;
                MaxTimeToReWrite = 20;
                MaxTimeToFind = 4;
            }
            if (ddr == DDRType.DDR4)
            {
                MaxNSR = 3;
                MinTimeToRead = 10;
                MinTimeToWrite = 10;
                MinTimeToReWrite = 15;
                MinTimeToFind = 3;

                MaxTimeToRead = 6;
                MaxTimeToWrite = 6;
                MaxTimeToReWrite = 8;
                MaxTimeToFind = 2;
            }
            if (ddr == DDRType.DDR5)
            {
                MaxNSR = 4;
                MinTimeToRead = 3;
                MinTimeToWrite = 3;
                MinTimeToReWrite = 4;
                MinTimeToFind = 1;

                MaxTimeToRead = 1;
                MaxTimeToWrite = 1;
                MaxTimeToReWrite = 2;
                MaxTimeToFind = 1;
            }
        }
        public DDRBase() { }
    }
}
