namespace DrillingFleet.Models
{
    public class RegionVM
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public bool IsActive { get; set; }
        public CountryVM Country { get; set; }
    }
}