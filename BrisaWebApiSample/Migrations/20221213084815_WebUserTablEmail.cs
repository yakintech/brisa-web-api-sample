using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrisaWebApiSample.Migrations
{
    /// <inheritdoc />
    public partial class WebUserTablEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "WebUsers");
        }
    }
}
