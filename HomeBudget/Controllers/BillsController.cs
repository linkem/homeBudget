using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBudget.BussinesLogic;
using HomeBudget.Entities;
using HomeBudget.Models.Bills;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeBudget.Controllers
{
    [Authorize]
    public class BillsController : Controller
    {
        private readonly IBillsService _billsService;

        public BillsController(IBillsService billsService)
        {
            this._billsService = billsService;
        }
        public IActionResult Index()
        {
            var bills = _billsService.GetAllBills();
            return View("AddBill");
        }

        public IActionResult BillsList(string search = null)
        {
            var bills = _billsService.GetAllBills(search);

            var billsModel = bills.Select(s => new BillModel
            {
                Amount = s.Amount,
                BillDate = s.BillDate,
                Description = s.Description,
                PersonName = s.Person.Name,
                Id = s.BillId
            }).ToList();

            return View(new BillsListViewModel { Bills = billsModel, Search = search });
        }
        public IActionResult AddBill(AddBillViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var entity = new BillEntity
            {
                CreatedBy = HttpContext.User.Identity.Name,
                CreatedDate = DateTime.Now,
                Description = model.Description,
                PersonId = model.PersonId,
                Amount = model.Amount,
                BillDate = model.BillDate
            };

            _billsService.AddBill(entity);
            return View(new AddBillViewModel());
        }

        public IActionResult GetAllBills()
        {
            _billsService.GetAllBills();


            return View();
        }
    }
}