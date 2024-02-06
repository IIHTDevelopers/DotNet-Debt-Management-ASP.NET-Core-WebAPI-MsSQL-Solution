using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.DataLayer;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Services.Repository
{
    public class DebtRepository : IDebtRepository
    {
        private readonly DebtDbContext _dbContext;
        public DebtRepository(DebtDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Debt> CreateDebt(Debt debt)
        {
            try
            {
                var result = await _dbContext.Debts.AddAsync(debt);
                await _dbContext.SaveChangesAsync();
                return debt;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteDebtById(int id)
        {
            try
            {
                _dbContext.Remove(_dbContext.Debts.Single(a => a.debtId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Debt> GetAllDebts()
        {
            try
            {
                var result = _dbContext.Debts.
                OrderByDescending(x => x.debtId).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Debt> GetDebtById(int id)
        {
            try
            {
                return await _dbContext.Debts.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Debt> UpdateDebt(DebtViewModel model)
        {
            var feature = await _dbContext.Debts.FindAsync(model.debtId);
            try
            {
                _dbContext.Debts.Update(feature);
                await _dbContext.SaveChangesAsync();
                return feature;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}