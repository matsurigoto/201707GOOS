using GOOS_SampleTests.DataModelForIntegrationTest;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GOOS_SampleTests.steps
{
    [Binding]
    public sealed class InsertTable
    {
        [Given(@"Budget table existed budgets")]
        public void GivenBudgetTableExistedBudgets(Table table)
        {

            //same with BudgetCreateSteps
            var budgets = table.CreateSet<Budgets>();
            using (var dbcontext = new GoosExampleEntities())
            {
                dbcontext.Budgets.AddRange(budgets);
                dbcontext.SaveChanges();
            }
        }
    }
}