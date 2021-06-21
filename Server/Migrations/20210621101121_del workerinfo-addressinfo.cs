using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class delworkerinfoaddressinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CovidPlanList_Addresses_AddressInfoAddressId",
                table: "CovidPlanList");

            migrationBuilder.DropForeignKey(
                name: "FK_CovidPlanList_Workers_WorkerInfoWorkerId",
                table: "CovidPlanList");

            migrationBuilder.DropIndex(
                name: "IX_CovidPlanList_AddressInfoAddressId",
                table: "CovidPlanList");

            migrationBuilder.DropIndex(
                name: "IX_CovidPlanList_WorkerInfoWorkerId",
                table: "CovidPlanList");

            migrationBuilder.DropColumn(
                name: "AddressInfoAddressId",
                table: "CovidPlanList");

            migrationBuilder.DropColumn(
                name: "WorkerInfoWorkerId",
                table: "CovidPlanList");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "CovidPlanList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "CovidPlanList");

            migrationBuilder.AddColumn<int>(
                name: "AddressInfoAddressId",
                table: "CovidPlanList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerInfoWorkerId",
                table: "CovidPlanList",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CovidPlanList_AddressInfoAddressId",
                table: "CovidPlanList",
                column: "AddressInfoAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CovidPlanList_WorkerInfoWorkerId",
                table: "CovidPlanList",
                column: "WorkerInfoWorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CovidPlanList_Addresses_AddressInfoAddressId",
                table: "CovidPlanList",
                column: "AddressInfoAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CovidPlanList_Workers_WorkerInfoWorkerId",
                table: "CovidPlanList",
                column: "WorkerInfoWorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
