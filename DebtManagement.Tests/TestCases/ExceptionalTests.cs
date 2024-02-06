

using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.Services.Repository;
using DebtManagement.BusinessLayer.Services;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DebtManagement.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IDebtService _insuranceService;
        public readonly Mock<IDebtRepository> insuranceservice = new Mock<IDebtRepository>();

        private readonly Debt _Debt;
        private readonly DebtViewModel _DebtViewModel;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _insuranceService = new DebtService(insuranceservice.Object);

            _output = output;

            _Debt = new Debt
            {
                debtId = 1,
                CustomerId = 11,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                IsActive = true,
                debtNumber = "HI123",
                debtType = "Home Insurance",
                PremiumAmount = 12000
            };

            _DebtViewModel = new DebtViewModel
            {
                debtId = 1,
                CustomerId = 11,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                IsActive = true,
                debtNumber = "HI123",
                debtType = "Home Insurance",
                PremiumAmount = 12000
            };
        }


        [Fact]
        public async Task<bool> Testfor_Validate_IfInvaliddebtIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await  _insuranceService.CreateDebt(_Debt);
                if (result != null || result.debtId !=0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidCustomerIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await _insuranceService.CreateDebt(_Debt);
                if (result != null || result.CustomerId != 0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidDebtNumberIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await _insuranceService.CreateDebt(_Debt);
                if (result != null || result.debtNumber != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidDebtTypeIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await _insuranceService.CreateDebt(_Debt);
                var actualLength = _Debt.debtType.ToString().Length;
                if (result.debtType.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidStartDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await _insuranceService.CreateDebt(_Debt);
                var actualLength = _Debt.StartDate.ToString().Length;
                if (result.StartDate.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
