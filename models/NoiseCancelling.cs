namespace CivHeadphoneExample_20210608.models
{
    public class NoiseCancelling : Wireless
    {
        public string Algorithm { get; set; }
        public NoiseCancelling(string name, uint weight, string type, bool microphone, string WirelessProtocol, string Algorithm, uint price) : base(name, weight, type, microphone, WirelessProtocol, price)
        {
            this.Algorithm = Algorithm;
        }
    }
}


