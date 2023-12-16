using EB.Game.Components.RAM;
using System.Text.Json.Serialization;

namespace EB.Game.Components
{
    public class RAMBase
    {
        public ulong Size;
        public int TimeToRead;
        public int TimeToWrite;
        public int TimeToReWrite;
        public int TimeToFind;
        [JsonPropertyName("NumberSimultaneousRequests")]
        public int NSR;
        public string RAMName;
        public DDRBase ddr;
        public enum OperationType
        {
            Read,
            Write,
            ReWrite,
        }
        public RAMBase(string Name, ulong size, int timeToRead, int timeToWrite, int timeToReWrite, int timeToFind, int NumberSimultaneousRequests, DDRBase ddr)
        {
            Size = size;
            TimeToRead = timeToRead;
            TimeToWrite = timeToWrite;
            TimeToReWrite = timeToReWrite;
            TimeToFind = timeToFind;
            NSR = NumberSimultaneousRequests;
            RAMName = Name;
            this.ddr = ddr;
        }
        public RAMBase() { }

        public void Wait(OperationType type)
        {
            if (type == OperationType.Read) Thread.Sleep(TimeToRead + TimeToFind);
            else if (type == OperationType.Write) Thread.Sleep(TimeToWrite + TimeToFind);
            else if (type == OperationType.ReWrite) Thread.Sleep(TimeToReWrite + TimeToFind);
        }
    }
}
