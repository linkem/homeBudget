using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBudget.BussinesLogic;
using HomeBudget.Models.People;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeBudget.Controllers
{
    [Authorize]
    public class PeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this._peopleService = peopleService;
        }
        public IActionResult Index()
        {
            var people = _peopleService.GetAllPeople();

            var peopleModel = people.Select(x => new PersonModel
            {
                Id = x.PersonId,
                Name = x.Name,
                RelationName = x.Relation.Description,
                TotalAmount = x.Bills.Sum( s=> s.Amount)
            }).ToList();

            return View(new PeopleListViewModel {People = peopleModel });
        }
    }
}