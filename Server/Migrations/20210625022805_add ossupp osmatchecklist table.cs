using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class addossupposmatchecklisttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeRun_Orders_ProductNo",
                table: "SizeRun");

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

            migrationBuilder.CreateTable(
                name: "OutsoleSuppliers",
                columns: table => new
                {
                    OutsoleSupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsoleSuppliers", x => x.OutsoleSupplierId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SizeRunModel_Orders_ProductNo",
                table: "SizeRunModel",
                column: "ProductNo",
                principalTable: "Orders",
                principalColumn: "ProductNo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeRunModel_Orders_ProductNo",
                table: "SizeRunModel");

            migrationBuilder.DropTable(
                name: "OutsoleSuppliers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SizeRun_Orders_ProductNo",
                table: "SizeRun",
                column: "ProductNo",
                principalTable: "Orders",
                principalColumn: "ProductNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
