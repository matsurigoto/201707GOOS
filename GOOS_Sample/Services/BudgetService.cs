using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GOOS_Sample.DataModels;
using GOOS_Sample.Interfaces;
using GOOS_Sample.ViewModels;

namespace GOOS_Sample.Services
{
    public class BudgetService : IBudgetService
    {
        public void Create(BudgetAddViewModel model)
        {
            using (var dbcontext = new GoosExamplePRDEntities())
            {
                var budget = new Budgets() { Amount = model.Amount, YearMonth = model.Month };
                dbcontext.Budgets.Add(budget);
                dbcontext.SaveChanges();
            }
        }
    }
}