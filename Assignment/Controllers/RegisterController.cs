using System.Web.Mvc;
using Business.Model;
using Business.Data.Repository;
using Business.Data;
using Business.Data.Services;
using System.Text;

namespace Assignment.Controllers
{
    public class RegisterController : Controller
    {
        private IRepository<REGISTRATION> _repository = null;
        public Context db = new Context();
        public RegisterController()
        {
            this._repository = new Repository<REGISTRATION>();
            Context db = new Context();
        }
        //
        // GET: /Register/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Register/Create
        public ActionResult Register()
        {
            ViewBag.CountryId = new SelectList(db.country, "ID", "COUNTRY_NAME");
            ViewBag.HowYouKnow = new SelectList(db.how_you_know, "ID", "Description");
            return View();
        }

        //
        // POST: /Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(REGISTRATION user)
        {
            if (ModelState.IsValid)
            {
                //var dbrec = db.registration.Find(user.ID);
                //dbrec.IsAgree = IsAgree;
                //dbrec.IsNewsletter = IsNewsLetter;
                _repository.Insert(user);
                _repository.Save();
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ViewBag.CountryId = new SelectList(db.country, "ID", "COUNTRY_NAME");
                ViewBag.HowYouKnow = new SelectList(db.how_you_know, "ID", "Description");
                return View(user);
            }
        }

        //
        // GET: /Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
