using HastaneUygulamasi.Data;
using HastaneUygulamasi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneUygulamasi.Controllers
{
    public class KatlarController : Controller
    {
        public readonly ApplicationDbContext _context;
        public KatlarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Listeleme
        public IActionResult Index()
        {
            return View(_context.Katlars.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Katlar kat)
        {
            _context.Katlars.Add(kat);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // Güncelle
        public IActionResult Edit(int id)
        {
            return View(_context.Katlars.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Katlar kat)
        {
            _context.Katlars.Update(kat);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // Sil
        public IActionResult Delete(int id)
        {
            return View(_context.Katlars.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Katlar kat)
        {
            _context.Katlars.Remove(kat);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
