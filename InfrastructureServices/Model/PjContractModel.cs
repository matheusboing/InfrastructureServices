using InfrastructureServices.Data.Enums;

namespace InfrastructureServices.Model
{
    public class PJContractModel
    {
        public int Id {set; get;}
        public string? Cnpj { set; get;}
        public string? BusinessName { set; get;} 
        public string? TradeName { set; get;}
        public DateTime ContractDate { set; get;}
        public float ContractValue { get; set; }

        // Enum - Weekly, monthly, or annually.
        public PaymentMethod Payment { get; set; }
        
    }
}
