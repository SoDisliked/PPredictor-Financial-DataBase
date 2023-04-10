using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace PPredictorDatabase.ModelOfData
{
    [DebuggerDisplay("{Name} (FinancialRisk = {FinancialRisk})")]
    public class Risk
    {
        [Key]
        public int RiskId { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public int FinanceId { get; set; }

        public string FinanceRiskId { get; set; }

        public string Portofolio { get; set; }

        [MaxLength(200)]

        public string Assets { get; set; }

        public int CashFlow { get; set; }

        public int CashAndCashEquivalent { get; set; }

        public int NetOperatingIncome { get; set; }

        public int LiquidAssets { get; set; }

        public int Debt { get; set; }

        public int TotalCosts { get; set; }

        [MaxLength(300)]
        public string Company { get; set; }

        public int MiliSeconds { get; set; }

        public int Bytes { get; set; }

        public decimal UnitVariablePrice { get; set; }

        [ForeignKey("CustomerFilePath")]
        public Customer Customer { get; set; }

        [ForeignKey("FinancialRisk")]
        public FinancialRisk FinancialRisk { get; set; }
    }
}