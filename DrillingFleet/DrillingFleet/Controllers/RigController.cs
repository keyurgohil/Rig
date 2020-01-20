using BusinessLogic;
using DrillingFleet.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DrillingFleet.Controllers
{
    public class RigController : Controller
    {
        // GET: Rig
        public ActionResult Index()
        {
            RigBO rigBO = new RigBO();
            List<RigDetailVM> rigDetailVMs = new List<RigDetailVM>();
            var rigDetails = rigBO.GetRigDetail();
            // Need to add mapper here that will map Business logic entity into View Model.
            return View(rigDetailVMs);
        }
    }
}