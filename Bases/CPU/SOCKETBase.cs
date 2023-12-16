using EB.Game.Components.RAM;
using Newtonsoft.Json;

namespace EB.Game.Components.CPU
{
    public class SOCKETBase
    {
        [JsonProperty]
        public DDRBase DDR { get; set; }

        [JsonProperty]
        public string SocketName { get; set; }

        public SOCKETBase(DDRBase dDR, string socketName)
        {
            DDR = dDR;
            SocketName = socketName;
        }

        public SOCKETBase() { }
    }
}