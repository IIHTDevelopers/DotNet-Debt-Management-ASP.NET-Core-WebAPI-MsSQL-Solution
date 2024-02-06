
using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.Services;
using DebtManagement.BusinessLayer.Services.Repository;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DebtManagement.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IDebtService _insuranceService;
        public readonly Mock<IDebtRepository> insuranceservice = new Mock<IDebtRepository>();

        private readonly Debt _Debt;
        private readonly DebtViewModel _DebtViewModel;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Create_Debt()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.CreateDebt(_Debt)).ReturnsAsync(_Debt);
                var result = await _insuranceService.CreateDebt(_Debt);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_Update_Debt()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.UpdateDebt(_DebtViewModel)).ReturnsAsync(_Debt);
                var result = await _insuranceService.UpdateDebt(_DebtViewModel);
                if (result != null)
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
        public async Task<bool> Testfor_GetDebtById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.GetDebtById(id)).ReturnsAsync(_Debt);
                var result = await _insuranceService.GetDebtById(id);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_DeleteDebtById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.DeleteDebtById(id)).ReturnsAsync(response);
                var result = await _insuranceService.DeleteDebtById(id);
                //Assertion
                if (result != null)
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