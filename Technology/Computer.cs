using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        public double Ram { get; set; }
        public readonly double Screensize;
        public string OS { get; set; }

    public Computer(double ram, double screenSize, string oS)
        {
            Ram = ram;
            Screensize = screenSize;
            OS = oS;

        }

        public void PrintStats()
        {
            Console.WriteLine($"RAM: {Ram}{Environment.NewLine}" + $"Screensize: {Screensize}{Environment.NewLine}" + $"OS: {OS}");
        }

        public void UpgradeRam(double Ram) 
        {
            Ram += uRam
        }

    }
}
