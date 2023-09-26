using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureServices.Migrations
{
    /// <inheritdoc />
    public partial class createrequestprinterinstallation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PrinterName = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    PrinterModel = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TypeOfConnection = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PersonResponsableForInstallation = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
