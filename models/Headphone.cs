namespace CivHeadphoneExample_20210608.models
{
    public class Headphone
    {


        public string Name { get; set; }
        
        // Expressed as grams
        public uint Weight { get; set; }

        /// Types available are: Open-Back, Closed-Back, In-Ear, Surround
        public string Type { get; set; }

        public bool Microphone { get; set; }

        // Expressed as cents
        public uint Price { get; set; }

        public Headphone(string name, uint weight, string type, bool microphone, uint price)
        {
            this.Name = name;
            this.Weight = weight;
            this.Type = type;
            this.Microphone = microphone;
            this.Price = price;
        }
    }
}