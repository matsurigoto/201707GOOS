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
                var budget = new Budgets() { Amount = entity.Amount, YearMonth = entity.YearMonth };
                dbcontext.Budgets.Add(budget);
                dbcontext.SaveChanges();
            }
        }
    }
}