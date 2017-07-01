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
        private IRepository<Budgets> _budgetRepository;

        public BudgetService(IRepository<Budgets> budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public void Create(BudgetAddViewModel model)
        {

            var budget = new Budgets() { Amount = model.Amount, YearMonth = model.Month };
            this._budgetRepository.Save(budget);
        }

        public event EventHandler Created;
        public event EventHandler Updated;
    }
}