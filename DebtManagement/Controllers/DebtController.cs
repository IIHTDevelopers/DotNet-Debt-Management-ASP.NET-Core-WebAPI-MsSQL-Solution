using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DebtManagement.Controllers
{
    [ApiController]
    public class DebtController : ControllerBase
    {
        private readonly IDebtService _DebtService;
        public DebtController(IDebtService DebtService)
        {
            _DebtService = DebtService;
        }

        [HttpPost]
        [Route("create-debt")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDebt([FromBody] Debt model)
        {
            var debtExists = await _DebtService.GetDebtById(model.debtId);
            if (debtExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Debt already exists!" });
            var result = await _DebtService.CreateDebt(model);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Debt creation failed! Please check details and try again." });

            return Ok(new Response { Status = "Success", Message = "Debt created successfully!" });

        }


        [HttpPut]
        [Route("update-debt")]
        public async Task<IActionResult> UpdateDebt([FromBody] DebtViewModel model)
        {
            var debt = await _DebtService.UpdateDebt(model);
            if (debt == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Debt With Id = {model.debtId} cannot be found" });
            }
            else
            {
                var result = await _DebtService.UpdateDebt(model);
                return Ok(new Response { Status = "Success", Message = "Debt updated successfully!" });
            }
        }

        [HttpDelete]
        [Route("delete-debt")]
        public async Task<IActionResult> DeleteDebt(int id)
        {
            var debt = await _DebtService.GetDebtById(id);
            if (debt == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Debt With Id = {id} cannot be found" });
            }
            else
            {
                var result = await _DebtService.DeleteDebtById(id);
                return Ok(new Response { Status = "Success", Message = "Debt deleted successfully!" });
            }
        }


        [HttpGet]
        [Route("get-debt-by-id")]
        public async Task<IActionResult> GetDebtById(int id)
        {
            var debt = await _DebtService.GetDebtById(id);
            if (debt == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Debt With Id = {id} cannot be found" });
            }
            else
            {
                return Ok(debt);
            }
        }

        [HttpGet]
        [Route("get-all-debts")]
        public async Task<IEnumerable<Debt>> GetAllDebts()
        {
            return _DebtService.GetAllDebts();
        }
    }
}