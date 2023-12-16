namespace EB.Game.Components
{
    public class Benchmark
    {
        public static int GetScore(RAMBase ram)
        {
            int Score = 0;
            int time = 0;
            while (time < 1000)
            {
                time += ram.TimeToWrite;
                Score++;
                time += ram.TimeToFind;
                Score++;
                time += ram.TimeToRead;
                Score++;
                time += ram.TimeToFind;
                Score++;
                time += ram.TimeToReWrite;
                Score++;
            }
            return Score;
        }
        public static int GetScore(SSDBase ssd)
        {
            int Score = 0;
            int time = 0;
            while (time < 1000)
            {
                time += ssd.TimeToWrite;
                Score++;
                time += ssd.TimeToRead;
                Score++;
                time += ssd.TimeToReWrite;
                Score++;
            }
            return Score;
        }
        public static int GetScore(HDDBase hdd)
        {
            int Score = 0;
            int time = 0;
            Random rnd = new Random();
            while (time < 10000)
            {
                time += hdd.IRT + rnd.Next(0, hdd.RndForWrite);
                Score++;
                time += hdd.IRT + rnd.Next(0, hdd.RndForRead);
                Score++;
                time += hdd.IRT + rnd.Next(0, hdd.RndForFind);
                Score++;
            }
            return Score;
        }
        public static int GetSingleScore(CPUBase cpu)
        {
            int Score = 0;
            int time = 0;
            time += cpu.Socket.DDR.MaxTimeToWrite;
            while (time <= 60000)
            {
                time += cpu.Socket.DDR.MaxTimeToReWrite;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSD;
                Score++;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSI;
                Score++;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSS;
                Score++;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSF;
                Score++;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSL;
                Score++;
                time += cpu.Socket.DDR.MaxTimeToRead;
                time += cpu.CSSs;
                Score++;
            }
            return Score;
        }
        public static int GetMultiScore(CPUBase cpu)
        {
            int Score = 0;
            if (cpu.ICC > cpu.Socket.DDR.MaxNSR)
            {
                for (int i = 0; i <= cpu.ICC - cpu.Socket.DDR.MaxNSR; i++)
                {
                    int time = 0;
                    time += cpu.Socket.DDR.MaxTimeToWrite;
                    while (time < 60000)
                    {
                        time += cpu.Socket.DDR.MaxTimeToReWrite;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSD;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSI;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSS;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSF;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSL;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSSs;
                        Score++;
                    }
                }
            }
            else
            {
                for (int i = 0; i <= cpu.Socket.DDR.MaxNSR - cpu.ICC; i++)
                {
                    int time = 0;
                    time += cpu.Socket.DDR.MaxTimeToWrite;
                    while (time < 60000)
                    {
                        time += cpu.Socket.DDR.MaxTimeToReWrite;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSD;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSI;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSS;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSF;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSL;
                        Score++;
                        time += cpu.Socket.DDR.MaxTimeToRead;
                        time += cpu.CSSs;
                        Score++;
                    }
                }
            }

            return Score;
        }
        public static int GetMultiScore(GPUBase gpu)
        {
            int Score = 0;
                for (int i = 0; i <= gpu.ICC; i++)
                {
                    int time = 0;
                    while (time < 15000)
                    {
                        time += gpu.CSD;
                        Score++;
                        time += gpu.CSI;
                        Score++;
                        time += gpu.CSS;
                        Score++;
                        time += gpu.CSF;
                        Score++;
                        time += gpu.CSL;
                        Score++;
                        time += gpu.CSSs;
                        Score++;
                    }
                }

            return Score;
        }
        public static int GetSingleScore(MBBase MotherBoard)
        {
            bool Posible = true;
            int none = 0;
            foreach (var s in MotherBoard.RAM) if (s != null) none++;
            if (none == MotherBoard.RAM.Length - 1) Posible = false;
            if (MotherBoard.Cpu == null) Posible = false;
            if (!Posible) return 0;
            else
            {
                int Score = 0;
                int time = 0;
                time += MotherBoard.RAM[0].TimeToWrite;
                while (time <= 60000)
                {
                    time += MotherBoard.RAM[0].TimeToReWrite;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSD;
                    Score++;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSI;
                    Score++;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSS;
                    Score++;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSF;
                    Score++;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSL;
                    Score++;
                    time += MotherBoard.RAM[0].TimeToRead;
                    time += MotherBoard.Cpu.CSSs;
                    Score++;
                }
                return Score;
            }
        }
        public static int GetMultiScore(MBBase MotherBoard)
        {
            bool Posible = true;
            int none = 0;
            foreach (var s in MotherBoard.RAM) if (s != null) none++;
            if (none == MotherBoard.RAM.Length - 1) Posible = false;
            if (MotherBoard.Cpu == null) Posible = false;
            if (!Posible) return 0;
            else
            {
                int Score = 0;
                if (MotherBoard.Cpu.ICC > MotherBoard.RAM[0].NSR)
                {
                    for (int i = 0; i <= MotherBoard.Cpu.ICC - MotherBoard.RAM[0].NSR; i++)
                    {
                        int time = 0;
                        time += MotherBoard.RAM[0].TimeToWrite;
                        while (time < 60000)
                        {
                            time += MotherBoard.RAM[0].TimeToReWrite;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSD;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSI;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSS;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSF;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSL;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSSs;
                            Score++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= MotherBoard.RAM[0].NSR - MotherBoard.Cpu.ICC; i++)
                    {
                        int time = 0;
                        time += MotherBoard.RAM[0].TimeToWrite;
                        while (time < 60000)
                        {
                            time += MotherBoard.RAM[0].TimeToReWrite;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSD;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSI;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSS;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSF;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSL;
                            Score++;
                            time += MotherBoard.RAM[0].TimeToRead;
                            time += MotherBoard.Cpu.CSSs;
                            Score++;
                        }
                    }
                }

                return Score;
            }
        }
    }
}
