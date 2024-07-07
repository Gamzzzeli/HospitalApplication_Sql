using HastaneUygulamasi.Data;
using HastaneUygulamasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HastaneUygulamasi.Controllers
{
    public class OdalarController : Controller
    {
        public readonly ApplicationDbContext context1;
        public OdalarController(ApplicationDbContext context)
        {
            context1 = context;
        }

        // Listeleme
        public IActionResult Index()
        {
            return View(context1.Odalars.ToList());
        }

        // Kaydetme
        public IActionResult Create()
        {
           // List<SelectList> odaid_liste = (from y in )
           return View();
        }
        [HttpPost]
        public IActionResult Create(Odalar oda)
        {
            context1.Odalars.Add(oda);
            context1.SaveChanges();
            return RedirectToAction("index");
        }

        // Güncelle
        public IActionResult Edit(int id)
        {
            return View(context1.Odalars.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(int id,Odalar oda)
        {
            context1.Odalars.Update(oda);
            context1.SaveChanges();
            return RedirectToAction("index");
        }

        // Sil
        public IActionResult Delete(int id)
        {
            return View(context1.Odalars.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Odalar oda)
        {
            context1.Odalars.Remove(oda);
            context1.SaveChanges();
            return RedirectToAction("index");
        }

        }
    }
