using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketsUA.Migrations
{
    /// <inheritdoc />
    public partial class _24124124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AirCompanyName",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlCompanyLogo",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirCompanyName",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "UrlCompanyLogo",
                table: "tickets");
        }
    }
}
