using System;
using CivHeadphoneExample_20210608.models;

namespace CivHeadphoneExample_20210608
{
    class Program
    {
        static void Main(string[] args)
        {
            Cable copperCable = new Cable("Copper", "3.5mm", 1000);
            Cable cloudCable = new Cable("Copper", "3.5mm", 3200);

            Wired mx50 = new Wired("MX50", 250, "Closed-Back", false, 15000, "2.5mm", copperCable);
            Wired HyperX = new Wired("HyperX Cloud Revolver S", 376, "Surround", true, 22500, "3.5mm", cloudCable);
            Wireless QC35 = new Wireless("Bose Quiet Comfort 35", 225, "Closed-Back", false, "Sample Protocol", 28500);
            NoiseCancelling NC56 = new NoiseCancelling("NC56", 300, "Closed-Back", true, "Sample Protocol", "Sample Algorith", 18500);
            // Create another Wired headphone
            // Create a Wirelss headphone
            // Create a NoiseCancelling headphone

            //create plugtype attribute
            //create WirelessProtocol attribute
            //create algorithm attribute

            // print the plugtype of the second wired headphone
            // print the WirelessProtocol of the wireless headphone
            // print the algorithm of the NoiseCancelling headphone

            System.Console.WriteLine(HyperX.PlugType);
            System.Console.WriteLine(QC35.WirelessProtocol);
            System.Console.WriteLine(NC56.Algorithm);
            //testing
        }
    }
}
