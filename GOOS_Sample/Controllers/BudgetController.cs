using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GOOS_Sample.DataModels;
using GOOS_Sample.Interfaces;
using GOOS_Sample.Services;
using GOOS_Sample.ViewModels;

namespace GOOS_Sample.Controllers
{
    public class BudgetController : Controller
    {

        private IBudgetService budgetService;

        public BudgetController(IBudgetService budgetService)
        {
            this.budgetService = budgetService;
        }

        // GET: Budget
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(BudgetAddViewModel model)
        {

            this.budgetService.Created += (sender, e) => { ViewBag.Message = "added successfully"; };
            this.budgetService.Updated += (sender, e) => { ViewBag.Message = "updated successfully"; };


            this.budgetService.Create(model);
            //ViewBag.Message = "added successfully";
            return View(model);
        }
    }
}