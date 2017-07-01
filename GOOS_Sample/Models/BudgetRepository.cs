using System;
using System.Linq;
using GOOS_Sample.DataModels;
using GOOS_Sample.Interfaces;

namespace GOOS_Sample.Models
{

    public class BudgetRepository : IRepository<Budgets>
    {
        public void Save(Budgets entity)
        {
            using (var dbcontext = new GoosExamplePRDEntities())
            {
                var budgetFromDb = dbcontext.Budgets.FirstOrDefault(x => x.YearMonth == entity.YearMonth);

                if (budgetFromDb == null)
                {
                    dbcontext.Budgets.Add(entity);
                }
                else
                {
                    budgetFromDb.Amount = entity.Amount;
                }

                dbcontext.SaveChanges();
            }

        }

        public Budgets Read(Func<Budgets, bool> predicate)
        {


            using (var dbcontext = new GoosExamplePRDEntities())
            {
                var firstBudget = dbcontext.Budgets.FirstOrDefault(predicate);
                return firstBudget;
            }
        }
    }
}