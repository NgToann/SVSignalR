using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVSignalR.Server.Migrations
{
    public partial class addcovidplanlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "CovidPlanList",
                columns: table => new
                {
                    WorkerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidPlanList", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_CovidPlanList_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            

            migrationBuilder.CreateIndex(
                name: "IX_CovidPlanList_AddressId",
                table: "CovidPlanList",
                column: "AddressId");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
