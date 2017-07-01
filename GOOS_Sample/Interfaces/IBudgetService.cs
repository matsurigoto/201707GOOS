using System;
using GOOS_Sample.ViewModels;

namespace GOOS_Sample.Interfaces
{
    public interface IBudgetService
    {
        void Create(BudgetAddViewModel budget);

        event EventHandler Created;
        event EventHandler Updated;
    }
}