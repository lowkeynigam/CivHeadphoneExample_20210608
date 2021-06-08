namespace CivHeadphoneExample_20210608.models
{
    public class Wireless : Headphone
    {
        public string WirelessProtocol { get; set; }
        public Wireless(string name, uint weight, string type, bool microphone, string WirelessProtocol, uint price) : base(name, weight, type, microphone, price)
        {
            this.WirelessProtocol = WirelessProtocol;
        }
    }
}