using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassSafe.Migrations
{
    /// <inheritdoc />
    public partial class addloginuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "user",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "user");
        }
    }
}
