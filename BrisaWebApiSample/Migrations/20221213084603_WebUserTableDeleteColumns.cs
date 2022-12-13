using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrisaWebApiSample.Migrations
{
    /// <inheritdoc />
    public partial class WebUserTableDeleteColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "WebUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "WebUsers");

    
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
