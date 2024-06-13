using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    public partial class PassWordCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Password",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");
        }
    }
}
