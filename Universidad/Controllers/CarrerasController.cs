using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models;
using Universidad.Repositories;

namespace Universidad.Controllers
{
    public class CarrerasController : Controller
    {
        private IRepository<Carrera> repo;

        public CarrerasController(IRepository<Carrera> _repo)
        {
            this.repo = _repo;

        }

        public IActionResult Index()
        {
            return View(repo.Listar());
        }

        public ActionResult Details(int id)
        {
            return View(repo.getById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carrera car)
        {
            try
            {
                repo.Add(car);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(repo.getById(id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Carrera car)
        {
            try
            {
                repo.Update(car);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(repo.getById(id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Carrera car)
        {
            try
            {
                repo.Del(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}