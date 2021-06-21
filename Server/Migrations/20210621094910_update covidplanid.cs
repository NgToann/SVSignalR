using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class updatecovidplanid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CovidPlanList",
                table: "CovidPlanList");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "CovidPlanList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CovidPlanId",
                table: "CovidPlanList",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CovidPlanList",
                table: "CovidPlanList",
                column: "CovidPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CovidPlanList",
                table: "CovidPlanList");

            migrationBuilder.DropColumn(
                name: "CovidPlanId",
                table: "CovidPlanList");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "CovidPlanList",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CovidPlanList",
                table: "CovidPlanList",
                column: "WorkerId");
        }
    }
}
