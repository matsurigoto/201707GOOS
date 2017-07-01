using GOOS_Sample.ViewModels;

namespace GOOS_Sample.Interfaces
{
    public interface IBudgetService
    {
        void Create(BudgetAddViewModel budget);
    }
}