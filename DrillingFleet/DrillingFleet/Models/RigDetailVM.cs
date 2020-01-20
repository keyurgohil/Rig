using System;

namespace DrillingFleet.Models
{
    public class RigDetailVM
    {
        public int RigDetailId { get; set; }
        public string RigName { get; set; }
        public int RigWaterDepth { get; set; }
        public int RigDrillingDepth { get; set; }
        public string CurrentBlockOrWell { get; set; }
        public DateTime CurrentLocationStartDate { get; set; }
        public DateTime CurrentLocationEndDate { get; set; }
        public RigTypeVM RigType { get; set; }
        public RigManagerVM RigManager { get; set; }
        public RegionVM CurrentLocation { get; set; }
    }
}