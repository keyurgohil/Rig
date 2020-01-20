using DrillingFleet.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IRigBO
    {
        List<RigDetail> GetRigDetail();
    }
}
