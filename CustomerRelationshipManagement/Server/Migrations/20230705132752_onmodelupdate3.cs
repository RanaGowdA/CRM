using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerRelationshipManagement.Server.Migrations
{
    public partial class onmodelupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Leads_Id",
                table: "Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Leads_Id",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Leads_Id",
                table: "Opportunities",
                column: "Id",
                principalTable: "Leads",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Leads_Id",
                table: "Projects",
                column: "Id",
                principalTable: "Leads",
                principalColumn: "LeadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Leads_Id",
                table: "Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Leads_Id",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Leads_Id",
                table: "Opportunities",
                column: "Id",
                principalTable: "Leads",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Leads_Id",
                table: "Projects",
                column: "Id",
                principalTable: "Leads",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
