using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    public class catagoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCatagory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCatagory(Catagory cat)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.AddCatagory(cat);
                return RedirectToAction("GetAllDetails");
            }
            return View();
        }
        public ActionResult GetAllDetails()
        {
            Repositary obj = new Repositary();
            ModelState.Clear();
            return View(obj.GetAllCatagory());
        }
        public ActionResult EditDetails(int id)
        {
            Repositary obj = new Repositary();
            return View(obj.GetAllCatagory().Find(Catagory => Catagory.cid == id));
        }
        [HttpPost]
        public ActionResult EditDetails(int id, Catagory cat)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.UpdateCatagory(cat);
                return RedirectToAction("GetAllDetails");

            }
            return View();

        }
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.DeleteCatagory(id);
                return RedirectToAction("GetAllDetails");
            }
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product pat)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.AddProduct(pat);
                return RedirectToAction("GetAllPDetails");
            }
            return View();
        }
        public ActionResult GetAllPDetails()
        {
            Repositary obj = new Repositary();
            ModelState.Clear();
            return View(obj.GetAllProduct());
        }
        public ActionResult EditPDetails(int id)
        {
            Repositary obj = new Repositary();
            return View(obj.GetAllProduct().Find(Product => Product.cid == id));
        }
        [HttpPost]
        public ActionResult EditPDetails(int id, Product pat)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.UpdateProduct(pat);
                return RedirectToAction("GetAllPDetails");

            }
            return View();

        }
        public ActionResult PDelete(int id)
        {
            if (ModelState.IsValid)
            {
                Repositary obj = new Repositary();
                obj.DeleteProduct(id);
                return RedirectToAction("GetAllPDetails");
            }
            return View();
        }

    }
}