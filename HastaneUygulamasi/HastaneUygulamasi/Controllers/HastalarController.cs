using HastaneUygulamasi.Data;
using HastaneUygulamasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HastaneUygulamasi.Controllers
{
    public class HastalarController : Controller
    {
        public readonly ApplicationDbContext context;
        public HastalarController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //Listeleme
        public IActionResult Index()
        {
            return View(context.Hastalar.ToList());
        }

        // Kaydetme
        public IActionResult Create()
        {
            List<SelectListItem> katid_liste = (from x in context.Katlars
                                                select new SelectListItem
                                                {
                                                    Text = x.KatNumarası,
                                                    Value = x.id.ToString()
                                                }).ToList();
            ViewBag.Katid = katid_liste;

            List<SelectListItem> odaid_liste = (from x in context.Odalars
                                                select new SelectListItem
                                                {
                                                    Text = x.OdaNumarası,
                                                    Value = x.id.ToString()
                                                }).ToList();
            ViewBag.Odaid = odaid_liste;

            return View();

        }
        [HttpPost]
        public IActionResult Create(Hastalar hasta)
        {
            context.Hastalar.Add(hasta);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        // Güncelleme
        public IActionResult Edit(int id)
        {
            List<SelectListItem> katid_liste = (from x in context.Katlars
                                                select new SelectListItem
                                                {
                                                    Text = x.id.ToString()
                                                }).ToList();
            ViewBag.Katid = katid_liste;

            List<SelectListItem> odaid_liste = (from x in context.Odalars
                                                select new SelectListItem
                                                {
                                                    Text = x.id.ToString()
                                                }).ToList();
            ViewBag.Odaid = odaid_liste;

            return View(context.Hastalar.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Hastalar hasta)
        {
            context.Hastalar.Update(hasta);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        // Sil
        public IActionResult Delete(int id)
        {
            var sil = context.Hastalar.Find(id);
            context.Hastalar.Remove(sil);
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
