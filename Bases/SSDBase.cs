namespace EB.Game.Components
{
    public class SSDBase
    {
        public ulong Size;
        public int TimeToRead;
        public int TimeToWrite;
        public int TimeToReWrite;
        public string SSDName;
        public enum OperationType
        {
            Read,
            Write,
            ReWrite
        }
        public SSDBase(string name, ulong size, int timeToRead, int timeToWrite, int timeToReWrite)
        {
            Size = size;
            TimeToRead = timeToRead;
            TimeToWrite = timeToWrite;
            TimeToReWrite = timeToReWrite;
            SSDName = name;
        }
        public SSDBase() { }

        public void Wait(OperationType type)
        {
            if (type == OperationType.Read) Thread.Sleep(TimeToRead);
            else if (type == OperationType.Write) Thread.Sleep(TimeToWrite);
            else if (type == OperationType.ReWrite) Thread.Sleep(TimeToReWrite);
        }
    }
}
