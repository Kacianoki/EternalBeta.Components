using EB.Game.Components;
using Newtonsoft.Json;

namespace EB.Game.Components
{
    public class GPUBase
    {
        [JsonProperty]
        public string GPUName { get; set; }
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

        public GPUBase(string GPUName, int Core, int LogicProcessors, int ICC, int CSD, int CSI, int CSS, int CSF, int CSL, int CSSs)
        {
            this.GPUName = GPUName;
            this.Core = Core;
            this.LogicProcessors = LogicProcessors;
            this.ICC = ICC;
            this.CSD = CSD;
            this.CSI = CSI;
            this.CSS = CSS;
            this.CSF = CSF;
            this.CSF = CSL;
            this.CSF = CSF;
            this.CSSs = CSF;
        }

        public GPUBase() { }

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