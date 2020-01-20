namespace DrillingFleet.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public bool IsActive { get; set; }
        public Country Country { get; set; }
    }
}