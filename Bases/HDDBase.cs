using System.Text.Json.Serialization;

namespace EB.Game.Components
{
    public class HDDBase
    {
        public ulong Size;
        public int IRT;
        public int RndForFind;
        public int RndForRead;
        public int RndForWrite;
        public enum OperationType
        {
            Find,
            Read,
            Write
        }
        public string HDDName;
        public HDDBase(string hDDName, ulong size, int InformationRetrievalTime, int rndForFind, int rndForRead, int rndForWrite)
        {
            Size = size;
            IRT = InformationRetrievalTime;
            RndForFind = rndForFind;
            RndForRead = rndForRead;
            RndForWrite = rndForWrite;
            HDDName = hDDName;
        }
        public HDDBase() { }

        public void Wait(OperationType type)
        {
            Random rnd = new Random();
            if(type == OperationType.Find) Thread.Sleep(IRT + rnd.Next(0, RndForFind));
            else if (type == OperationType.Read) Thread.Sleep(IRT + rnd.Next(0, RndForRead));
            else if (type == OperationType.Write) Thread.Sleep(IRT + rnd.Next(0, RndForWrite));
        }
    }
}
