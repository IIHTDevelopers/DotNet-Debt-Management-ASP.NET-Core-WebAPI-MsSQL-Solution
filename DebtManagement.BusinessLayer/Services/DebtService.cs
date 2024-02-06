using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.Services.Repository;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Services
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _DebtRepository;

        public DebtService(IDebtRepository DebtRepository)
        {
            _DebtRepository = DebtRepository;
        }

        public async Task<Debt> CreateDebt(Debt Debt)
        {
            return await _DebtRepository.CreateDebt(Debt);
        }

        public async Task<bool> DeleteDebtById(int id)
        {
            return await _DebtRepository.DeleteDebtById(id);
        }

        public List<Debt> GetAllDebts()
        {
            return _DebtRepository.GetAllDebts();
        }

        public async Task<Debt> GetDebtById(int id)
        {
            return await _DebtRepository.GetDebtById(id);
        }

        public async Task<Debt> UpdateDebt(DebtViewModel model)
        {
            return await _DebtRepository.UpdateDebt(model);
        }
    }
}