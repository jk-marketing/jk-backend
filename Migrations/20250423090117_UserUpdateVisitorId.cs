using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JK_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdateVisitorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VisitorId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitorId",
                table: "Users");
        }
    }
}
