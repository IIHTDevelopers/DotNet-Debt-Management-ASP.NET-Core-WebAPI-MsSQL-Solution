
using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.Services.Repository;
using DebtManagement.BusinessLayer.Services;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DebtManagement.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IDebtService _insuranceService;
        public readonly Mock<IDebtRepository> insuranceservice = new Mock<IDebtRepository>();

        private readonly Debt _Debt;
        private readonly DebtViewModel _DebtViewModel;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_debtNumber_NotEmpty()
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
                var actualLength = _Debt.debtNumber.ToString().Length;
                if (result.debtNumber.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_PremiumAmount_NotEmpty()
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
                var actualLength = _Debt.PremiumAmount.ToString().Length;
                if (result.PremiumAmount.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_CustomerId_NotEmpty()
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
                var actualLength = _Debt.CustomerId.ToString().Length;
                if (result.CustomerId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_debtId_NotEmpty()
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
                var actualLength = _Debt.debtId.ToString().Length;
                if (result.debtId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_debtType_NotEmpty()
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
        public async Task<bool> Testfor_StartDate_NotEmpty()
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