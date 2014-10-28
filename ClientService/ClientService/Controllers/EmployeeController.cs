using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ClientService.Models;
using ClientService.PeopleReference;

namespace ClientService.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            var client = new PeopleServiceClient();

            var peopleFromService = client.GetListOfPeople();

            var people = new PeopleModelList();
            foreach (var item in peopleFromService)
            {
                people.Add(new PeopleModel()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Email = item.Email,
                    Country = item.Country,
                    Contact = item.Phone
                });
            }

            client.Close();

            return View(people);

        }

        public ActionResult Details(string name)
        {
            
            var client = new PeopleServiceClient();

            var peopleDetails = client.GetPerson(name);

            ViewBag.ToString();

            return View(peopleDetails);
            }

        }

    }

