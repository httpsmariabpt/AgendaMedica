using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaMedica.Data.Migrations
{
    /// <inheritdoc />
    public partial class alterTableAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Agenda");
        }
    }
}
