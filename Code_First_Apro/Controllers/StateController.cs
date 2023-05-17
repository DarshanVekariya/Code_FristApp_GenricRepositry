using DataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Location;

namespace Code_First_Apro.Controllers
{
    public class StateController : Controller
    {                   
        private readonly IUnitOfWork _db;
        public StateController(IUnitOfWork Db)
        {
            _db = Db;
            
        }
        public IActionResult Index()
        {

            //return View(_db.StateRepository.GetAll());
            //return View(p);
            List<StateTbl> states = _db.StateRepository.GetAll().ToList();
            foreach (var item in states)
            {
                item.Country = _db.CountryRepository.Get(item.fkContryId);
            }

            return View(states);
        }
        public IActionResult Create()
        {
            ViewBag.fkContryId = new SelectList(_db.CountryRepository.GetAll(), "CountryId", "CountryName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(StateTbl s)
        {
            _db.StateRepository.Add(s);
            _db.Completed();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _db.StateRepository.Delete(id);
            return RedirectToAction("Index");   
        }

        public IActionResult Edit(int id)  
        {
            ViewBag.fkContryId = new SelectList(_db.CountryRepository.GetAll(), "CountryId", "CountryName");
            return View(_db.StateRepository.Get(id));
        }

        [HttpPost]

        public IActionResult Edit(StateTbl s)
        {
            _db.StateRepository.Update(s);
            _db.Completed();
            return RedirectToAction("Index");
        }
    }
}
