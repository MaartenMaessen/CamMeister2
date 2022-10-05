using CamMeister2.Data;
using Microsoft.AspNetCore.Mvc;
using CamMeister2.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Authorization;

namespace CamMeister.Controllers
{
    public class Camera_InfoController : Controller
    {
        private readonly ApplicationDbContext database;

        public Camera_InfoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Camera_Info> objCamera_InfoList = database.Camera_Info;
            return View(objCamera_InfoList);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE VIEW
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Camera_Info Camera_Info)
        {
            if (ModelState.IsValid)
            {
                database.Camera_Info.Add(Camera_Info);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET _ DELETE VIEW
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var Camera_Info = database.Camera_Info.FirstOrDefault(u => u.Id == Id);
            if (Camera_Info == null)
            {
                return NotFound();
            }

            return View(Camera_Info);
        }

        //POST - DELETE VIEW
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var Camera_Info = database.Camera_Info.Find(Id);
            if (Camera_Info == null)
            {
                return NotFound();
            }

            database.Camera_Info.Remove(Camera_Info);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
