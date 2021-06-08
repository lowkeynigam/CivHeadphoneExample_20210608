using System;
using CivHeadphoneExample_20210608.models;

namespace CivHeadphoneExample_20210608
{
    class Program
    {
        static void Main(string[] args)
        {
            Cable copperCable = new Cable("Copper", "3.5mm", 1000);

            Wired mx50 = new Wired("MX50", 250, "Closed-Back", false, 15000, "2.5mm", copperCable);

            // Create another Wired headphone
            // Create a Wirelss headphone
            // Create a NoiseCancelling headphone

            // print the plugtype of the second wired headphone
            // print the WirelessProtocol of the wireless headphone
            // print he algorithm of the NoiseCancelling headphone

            System.Console.WriteLine(mx50.Name);
            System.Console.WriteLine(mx50.Cable.Material);
            System.Console.WriteLine(copperCable.Material);
        }
    }
}
