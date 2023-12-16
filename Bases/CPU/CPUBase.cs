using EB.Game.Components.CPU;
using EB.Game.Components;
using Newtonsoft.Json;

namespace EB.Game.Components
{
    public class CPUBase
    {
        [JsonProperty]
        public string CPUName = "NN";
        [JsonProperty]
        public int Core = 1;
        [JsonProperty]
        public int LogicProcessors = 1;
        [JsonProperty]
        public int ICC = 2;
        [JsonProperty]
        public int CSD = 200;
        [JsonProperty]
        public int CSI = 100;
        [JsonProperty]
        public int CSS = 500;
        [JsonProperty]
        public int CSF = 200;
        [JsonProperty]
        public int CSL = 200;
        [JsonProperty]
        public int CSSs = 100;
        [JsonProperty]
        public SOCKETBase Socket;
        public CPUBase(string Name, int Core, int LogicProcessors, int IterativeComputingCapability, int CalculationSpeedDouble, int CalculationSpeedInt, int CalculationSpeedString,
    int CalculationSpeedFloat, int CalculationSpeedLong, int CalculationSpeedShort, SOCKETBase socket)
        {
            CPUName = Name; this.Core = Core; this.LogicProcessors = LogicProcessors; ICC = IterativeComputingCapability; CSD = CalculationSpeedDouble; CSI = CalculationSpeedInt; CSS = CalculationSpeedString;
            CSF = CalculationSpeedFloat; CSL = CalculationSpeedLong; CSSs = CalculationSpeedShort; Socket = socket;
        }
        public CPUBase() { }
        int ICCNow = 0;
        object locker;
        public int Resolve(Task<int> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSI);
            task.Wait();
            return task.Result;
        }
        public uint Resolve(Task<uint> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSI);
            task.Wait();
            return task.Result;
        }
        public double Resolve(Task<double> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSD);
            task.Wait();
            return task.Result;
        }
        public float Resolve(Task<float> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSF);
            task.Wait();
            return task.Result;
        }
        public long Resolve(Task<long> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSL);
            task.Wait();
            return task.Result;
        }
        public ulong Resolve(Task<ulong> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSL);
            task.Wait();
            return task.Result;
        }
        public short Resolve(Task<short> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSSs);
            task.Wait();
            return task.Result;
        }
        public ushort Resolve(Task<ushort> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            Thread.Sleep(CSSs);
            task.Wait();
            return task.Result;
        }
        public string Resolve(Task<string> task)
        {
            lock (locker)
            {
                while (ICCNow >= ICC) ;
                ICCNow++;
            }
            task.Wait();
            return task.Result;
        }
    }
}
