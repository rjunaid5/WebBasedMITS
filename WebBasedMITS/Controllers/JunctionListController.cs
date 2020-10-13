using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeBBasedMITSData;

namespace WebBasedMITS.Controllers
{
    public class JunctionListController : Controller
    {
        // GET: JunctionList
        private IRepository<JunctionList> repository = null;
        JunctionListRepository junctionlistRepository = new JunctionListRepository();
        public ActionResult Index()
        {
            return View();
        }
        public JunctionListController()
        {
            this.repository = new GenericRepository<JunctionList>();
        }
        public JunctionListController(GenericRepository<JunctionList> repository)
        {
            this.repository = repository;
        }

        public async Task<ActionResult> GetJunctionList()
        {
            List<JunctionList> junctionsList1;
            junctionsList1 = await junctionlistRepository.GetJunctionLists().ToListAsync();
            return View(junctionsList1);
        }
        public ActionResult Create()//this is used to call create form to enter fields after user click on the create button the bottom Create is called
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(JunctionList junction)//this is called when user clicked on create save button in the form
        {
            if (ModelState.IsValid)
            {
                repository.Insert(junction);
                repository.Save();
                return RedirectToAction("GetJunctionList");
            }
            return View(junction);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var employee = junctionlistRepository.mITSDatabaseEntities.JunctionLists.SingleOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(JunctionList junction)
        {
            if (ModelState.IsValid)
            {

                repository.Update(junction);
                repository.Save();
                return RedirectToAction("GetJunctionList");
            }

            return View(junction);
        }
        public ActionResult DetailsByID(int Id)
        {


            var junction = repository.GetById(Id);

            if (junction == null)
            {
                return HttpNotFound();
            }
            return View(junction);
        }
        public ActionResult Delete(int? Id)//this is used to call delete form to enter fields after user click on the delete button the bottom delete is called
        {
            var junction = junctionlistRepository.mITSDatabaseEntities.JunctionLists.SingleOrDefault(e => e.Id == Id);

            if (junction == null)
            {
                return HttpNotFound();
            }
            return View(junction);
        }

        [HttpPost]//the following is called when submit is used in the post form in cshtml
        public ActionResult Delete(int Id)//this is called when user clicked on delete button in the form
        {
            repository.Delete(Id);
            repository.Save();
            return RedirectToAction("GetJunctionList");
        }
    }
}