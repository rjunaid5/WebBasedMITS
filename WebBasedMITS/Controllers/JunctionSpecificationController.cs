using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeBBasedMITSData;

namespace WebBasedMITS.Controllers
{
    public class JunctionSpecificationController : Controller
    {
        // GET: JunctionSpecification
        private IRepository<JunctionList> repository = null;
        JunctionListRepository junctionlistRepository = new JunctionListRepository();
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> JunctionListSpecification()
        {
            List<JunctionList> junctionsList1;
            junctionsList1 = await junctionlistRepository.GetJunctionLists().ToListAsync();
            return View(junctionsList1);
        }
    }
}