using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrisaWebApiSample.Migrations
{
    /// <inheritdoc />
    public partial class WebUserTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "WebUsers");
        }
    }
}


//update-database