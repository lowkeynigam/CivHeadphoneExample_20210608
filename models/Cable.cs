namespace CivHeadphoneExample_20210608.models
{
    public class Cable
    {
        public string Material { get; set; }
        public string ConnectorType { get; set; }
        
        // expressed as mm
        public uint Length { get; set; }

        public Cable(string material, string connectorType, uint length)
        {
            this.Material = material;
            this.ConnectorType = connectorType;
            this.Length = length;
        }
    }
}