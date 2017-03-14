using System.Web.Mvc;
using Business.Model;
using Business.Data.Repository;
using Business.Data;
using Business.Data.Services;
using System.Linq;
using System.Web.Security;
using System;
using System.Web;

namespace Assignment.Controllers
{
    public class AccountController : Controller
    {
        public Context db = new Context();
        // GET: /Account/
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(REGISTRATION user)
        {

                var userAccount = db.registration.First(u => u.Username == user.Username && u.Password == user.Password);
                if (userAccount != null)
                {
                    Session["Username"] = userAccount.Username.ToString();
                    Session["Full_Name"] = userAccount.Full_Name.ToString();
                    //return RedirectToAction("Index", "Orders");
                }
                else
                {
                    ModelState.AddModelError("", "Login Failed");

                }
            return View(user);
        }
        public ActionResult LogOut() //IF (ID > 0)
        {
            this.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            this.Response.Cache.SetNoStore();
            Session.Clear();
            Session.Abandon(); // it will clear the session at the end of request
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //
        // GET: /Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Account/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Account/Edit/5
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
        // GET: /Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Account/Delete/5
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
