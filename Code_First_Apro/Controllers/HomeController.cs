using Code_First_Apro.Models;
using DataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using Models.Location;
using System.Diagnostics;
using System.Net;

namespace Code_First_Apro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _db;

        public HomeController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.CountryRepository.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(CountryTbl c)
        {
            _db.CountryRepository.Add(c);
            _db.Completed();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_db.CountryRepository.Get(id)); 
        }
        [HttpPost]
        public IActionResult Edit(CountryTbl c)
        {
            _db.CountryRepository.Update(c);
            _db.Completed();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           _db.CountryRepository.Delete(id);
            _db.Completed();
            return RedirectToAction("Index");   
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}