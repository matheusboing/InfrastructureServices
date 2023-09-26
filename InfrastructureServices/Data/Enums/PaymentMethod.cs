using System.ComponentModel;

namespace InfrastructureServices.Data.Enums
{
    public enum PaymentMethod
    {
        [Description("Semanalmente")]
        Weekly = 0,
        [Description("Mensalmente")]
        Monthly = 1,
        [Description("Anualmente")]
        Anually = 2
    }
}
