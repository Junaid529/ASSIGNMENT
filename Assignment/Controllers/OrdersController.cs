using System.Web.Mvc;
using Business.Model;
using Business.Data.Repository;
using Business.Data;
using Business.Data.Services;
using Assignment.Controllers;
using System.Linq;

namespace Assignment.Controllers
{
    public class OrdersController : Controller
    {
        private IRepository<ORDER_WAREHOUSE> _repository = null;
        private ModelServices model = new ModelServices();
        public Context db = new Context();
        public OrdersController()
        {
            this._repository = new Repository<ORDER_WAREHOUSE>();
            Context db = new Context();
        }

        //
        // GET: /Orders/
        public ActionResult Index()
        {
            var orders = _repository.GetAll();
            return View(orders);
        }

        //
        // GET: /Orders/Details/5
        public ActionResult Details(int id)
        {
            var order = _repository.GetById(id);
            return View(order);
        }
        //
        // GET: /Orders/Create
        public ActionResult Create()
        {
            Context db = new Context();
            ViewBag.CountryId = new SelectList(db.country, "ID", "COUNTRY_NAME");
            ViewBag.CitationId = new SelectList(db.citation, "ID", "CIT_NAME");
            ViewBag.LanguageId = new SelectList(db.languages, "ID", "DESCRIPTION");
            ViewBag.ReferenceId = new SelectList(db.references, "ID", "REF_NAME");
            return View();
        }
        //
        public JsonResult GetAll()
        {
            var data = db.order_warehouse.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        //
        [HttpPost]
        public ActionResult AddOrder(ORDER_WAREHOUSE orders)
        {
            _repository.Insert(orders);
            _repository.Save();
            return Json(orders, JsonRequestBehavior.AllowGet);
        }
         //POST: /Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ORDER_WAREHOUSE orders)
        {
            //if User session
            if(ModelState.IsValid)
            {
                _repository.Insert(orders);
                _repository.Save();
                return RedirectToAction("Done");
            }
            return View(orders);
        }
        public ActionResult Done()
        {
            return View();
        }
        //
        // GET: /Orders/Edit/5
        public ActionResult Edit(int id)
        {
            var order = _repository.GetById(id);
            return View(order);
        }

        //
        // POST: /Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(ORDER_WAREHOUSE order)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(order);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(order);
            }
        }

        //
        // GET: /Orders/Delete/5
        public ActionResult Delete(int id)
        {
            var order = _repository.GetById(id);
            return View(order);
        }

        //
        // POST: /Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var order = _repository.GetById(id);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}
