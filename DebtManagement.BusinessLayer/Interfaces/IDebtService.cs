using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Interfaces
{
    public interface IDebtService
    {
        List<Debt> GetAllDebts();
        Task<Debt> CreateDebt(Debt Debt);
        Task<Debt> GetDebtById(int id);
        Task<bool> DeleteDebtById(int id);
        Task<Debt> UpdateDebt(DebtViewModel model);
    }
}
