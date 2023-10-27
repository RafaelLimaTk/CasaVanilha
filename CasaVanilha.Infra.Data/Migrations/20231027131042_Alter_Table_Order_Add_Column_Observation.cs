using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaVanilha.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Alter_Table_Order_Add_Column_Observation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observation",
                table: "Orders",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observation",
                table: "Orders");
        }
    }
}
