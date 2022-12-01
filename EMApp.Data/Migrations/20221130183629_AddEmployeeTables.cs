using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMApp.Data.Migrations
{
    public partial class AddEmployeeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeLeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DefaultDays = table.Column<int>(nullable: false),
                    DateCreted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveAllocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDays = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Period = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: true),
                    EmloyeeId = table.Column<string>(nullable: true),
                    EmloyeeLeaveTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveAllocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocation_AspNetUsers_EmloyeeId",
                        column: x => x.EmloyeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocation_EmployeeLeaveType_EmloyeeLeaveTypeId",
                        column: x => x.EmloyeeLeaveTypeId,
                        principalTable: "EmployeeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeId = table.Column<string>(nullable: true),
                    ApprovedEmployeeId = table.Column<string>(nullable: true),
                    EmployeeLeaveTypeId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    RequestComments = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: true),
                    Cancelled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequest_AspNetUsers_ApprovedEmployeeId",
                        column: x => x.ApprovedEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequest_EmployeeLeaveType_EmployeeLeaveTypeId",
                        column: x => x.EmployeeLeaveTypeId,
                        principalTable: "EmployeeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequest_AspNetUsers_RequestingEmployeeId",
                        column: x => x.RequestingEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocation_EmloyeeId",
                table: "EmployeeLeaveAllocation",
                column: "EmloyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocation_EmloyeeLeaveTypeId",
                table: "EmployeeLeaveAllocation",
                column: "EmloyeeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequest_ApprovedEmployeeId",
                table: "EmployeeLeaveRequest",
                column: "ApprovedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequest_EmployeeLeaveTypeId",
                table: "EmployeeLeaveRequest",
                column: "EmployeeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequest_RequestingEmployeeId",
                table: "EmployeeLeaveRequest",
                column: "RequestingEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLeaveAllocation");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveRequest");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveType");
        }
    }
}
