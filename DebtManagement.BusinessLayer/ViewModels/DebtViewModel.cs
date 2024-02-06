using System;
using System.Collections.Generic;
using System.Text;

namespace DebtManagement.BusinessLayer.ViewModels
{
    public class DebtViewModel
    {
        public int debtId { get; set; }
        public string debtNumber { get; set; }
        public string debtType { get; set; }
        public decimal PremiumAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
    }
}
