using InfrastructureServices.Data.Enums;

namespace InfrastructureServices.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        // Enum - CLT or PJ
        public TypeOfContract Contract { get; set; }
        public string? Position { get; set; }
        public string? Department {  get; set; }
        public string? Email { get; set; }

    }
}
