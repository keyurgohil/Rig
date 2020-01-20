using System;

namespace DrillingFleet.Models
{
    public class RigDetail
    {
        public int RigDetailId { get; set; }
        public string RigName { get; set; }
        public int RigWaterDepth { get; set; }
        public int RigDrillingDepth { get; set; }
        public string CurrentBlockOrWell { get; set; }
        public DateTime CurrentLocationStartDate { get; set; }
        public DateTime CurrentLocationEndDate { get; set; }
        public RigType RigType { get; set; }
        public RigManager RigManager { get; set; }
        public Region CurrentLocation { get; set; }
    }
}