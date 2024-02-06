using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Services.Repository
{
    public interface IDebtRepository
    {
        List<Debt> GetAllDebts();
        Task<Debt> CreateDebt(Debt Debt);
        Task<Debt> GetDebtById(int id);
        Task<bool> DeleteDebtById(int id);
        Task<Debt> UpdateDebt(DebtViewModel model);
    }
}
