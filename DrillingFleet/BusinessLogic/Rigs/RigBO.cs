using DrillingFleet.Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class RigBO : IRigBO
    {
        public List<RigDetail> GetRigDetail()
        {
            Country country = new Country()
            {
                CountryId = 1,
                CountryName = "abc"
            };
            Region region = new Region()
            {
                RegionId = 1,
                RegionName = "Abc",
                Country = country,
                IsActive = true
            };
            RigManager rigManager = new RigManager()
            {
                RigManagerId = 1,
                RigManagerName = "abc"
            };
            RigType rigType = new RigType()
            {
                RigTypeId = 1,
                RigTypeName = "abc",
                IsActive = true
            };
            List<RigDetail> rigDetails = new List<RigDetail>();
            rigDetails.Add(new RigDetail()
                            {
                                 RigDetailId = 1,
                                 RigName = "Abc",
                                 RigWaterDepth = 300,
                                 RigDrillingDepth = 30000,
                                 CurrentBlockOrWell = "abc",
                                 CurrentLocationEndDate = DateTime.Parse("01-01-2020"),
                                 CurrentLocationStartDate = DateTime.Parse("10-10-2020"),
                                 CurrentLocation = region,
                                 RigManager = rigManager
                            });
            return rigDetails;
        }
    }
}
