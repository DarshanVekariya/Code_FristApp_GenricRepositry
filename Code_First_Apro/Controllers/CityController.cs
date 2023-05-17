using DataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Location;

namespace Code_First_Apro.Controllers
{
    public class CityController : Controller
    {
        private readonly IUnitOfWork _db;
        public CityController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<CityTbl> cities = _db.CityRepository.GetAll().ToList();
            foreach (var item in cities)
            {
                item.State = _db.StateRepository.Get(item.fkStateId);
            }

            return View(cities);
        }
        public IActionResult Create()
        {
            ViewBag.fkStateId = new SelectList(_db.StateRepository.GetAll(), "StateId", "StateName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(CityTbl C)
        {
            _db.CityRepository.Add(C);
            _db.Completed();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _db.CityRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.fkStateId = new SelectList(_db.StateRepository.GetAll(), "StateId", "StateName");
            return View(_db.CityRepository.Get(id));
        }

        [HttpPost]

        public IActionResult Edit(CityTbl C)
        {
            _db.CityRepository.Update(C);
            _db.Completed();
            return RedirectToAction("Index");
        }
    }
}
