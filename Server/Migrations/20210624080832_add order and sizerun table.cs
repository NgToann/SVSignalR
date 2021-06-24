using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class addorderandsizeruntable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ProductNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GTNPONo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArticleNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PatternNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidsoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutsoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    Reviser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ProductNo);
                });

            migrationBuilder.CreateTable(
                name: "SizeRun",
                columns: table => new
                {
                    SizeRunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutsoleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidsoleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdateOutsoleSizeByArticle = table.Column<bool>(type: "bit", nullable: false),
                    OrderProductNo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeRun", x => x.SizeRunId);
                    table.ForeignKey(
                        name: "FK_SizeRun_Orders_OrderProductNo",
                        column: x => x.OrderProductNo,
                        principalTable: "Orders",
                        principalColumn: "ProductNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SizeRun_OrderProductNo",
                table: "SizeRun",
                column: "OrderProductNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SizeRun");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
