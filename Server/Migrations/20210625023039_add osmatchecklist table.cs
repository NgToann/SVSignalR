using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class addosmatchecklisttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeRunModel_Orders_ProductNo",
                table: "SizeRunModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeRunModel",
                table: "SizeRunModel");

            migrationBuilder.RenameTable(
                name: "SizeRunModel",
                newName: "SizeRun");

            migrationBuilder.RenameIndex(
                name: "IX_SizeRunModel_ProductNo",
                table: "SizeRun",
                newName: "IX_SizeRun_ProductNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeRun",
                table: "SizeRun",
                column: "SizeRunId");

            migrationBuilder.CreateTable(
                name: "OutsoleMaterialCheckingList",
                columns: table => new
                {
                    OSCheckingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductNo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutsoleSupplierId = table.Column<int>(type: "int", nullable: false),
                    SizeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeNoUpper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Reject = table.Column<int>(type: "int", nullable: false),
                    ReturnReject = table.Column<int>(type: "int", nullable: false),
                    ReturnRemark = table.Column<int>(type: "int", nullable: false),
                    ErrorId = table.Column<int>(type: "int", nullable: false),
                    Excess = table.Column<int>(type: "int", nullable: false),
                    WorkingCard = table.Column<int>(type: "int", nullable: false),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false),
                    IsRelease = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReleasedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsoleMaterialCheckingList", x => x.OSCheckingID);
                    table.ForeignKey(
                        name: "FK_OutsoleMaterialCheckingList_Orders_ProductNo",
                        column: x => x.ProductNo,
                        principalTable: "Orders",
                        principalColumn: "ProductNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutsoleMaterialCheckingList_OutsoleSuppliers_OutsoleSupplierId",
                        column: x => x.OutsoleSupplierId,
                        principalTable: "OutsoleSuppliers",
                        principalColumn: "OutsoleSupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutsoleMaterialCheckingList_OutsoleSupplierId",
                table: "OutsoleMaterialCheckingList",
                column: "OutsoleSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsoleMaterialCheckingList_ProductNo",
                table: "OutsoleMaterialCheckingList",
                column: "ProductNo");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeRun_Orders_ProductNo",
                table: "SizeRun",
                column: "ProductNo",
                principalTable: "Orders",
                principalColumn: "ProductNo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeRun_Orders_ProductNo",
                table: "SizeRun");

            migrationBuilder.DropTable(
                name: "OutsoleMaterialCheckingList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeRun",
                table: "SizeRun");

            migrationBuilder.RenameTable(
                name: "SizeRun",
                newName: "SizeRunModel");

            migrationBuilder.RenameIndex(
                name: "IX_SizeRun_ProductNo",
                table: "SizeRunModel",
                newName: "IX_SizeRunModel_ProductNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeRunModel",
                table: "SizeRunModel",
                column: "SizeRunId");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeRunModel_Orders_ProductNo",
                table: "SizeRunModel",
                column: "ProductNo",
                principalTable: "Orders",
                principalColumn: "ProductNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
