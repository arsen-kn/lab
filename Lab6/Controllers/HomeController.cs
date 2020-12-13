using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab6;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {

        Lab6Context db = new Lab6Context();

        public ActionResult Index()
        {

            IEnumerable<People> people = db.People;
            ViewBag.People = people;
            return View();
        }
        [HttpGet]
        public ActionResult AddPeople(int id = 0)
        {
            return View();
        }
        [HttpPost]
        public void AddPeople(People people)
        {
            db.People.Add(people);
            db.SaveChanges();
            Response.Redirect("/Home");
        }
        [HttpGet]
        public ActionResult EditPeople(int id = 0)
        {
            ViewBag.PeopleId = id;
            People people = db.People
                            .Where(o => o.Id == id)
                            .FirstOrDefault();

            ViewBag.PeopleFirstName = people.FirstName;
            ViewBag.PeopleLastName = people.LastName;
            ViewBag.PeopleFlatId = people.FlatId;
            return View();
        }
        [HttpPost]
        public void EditPeople(People people)
        {
            People people_update = db.People
                            .Where(o => o.Id == people.Id)
                            .FirstOrDefault();

            people_update.FirstName = people.FirstName;
            people_update.LastName = people.LastName;
            people_update.FlatId = people.FlatId;

            db.SaveChanges();
            Response.Redirect("/Home");
        }
    }
}