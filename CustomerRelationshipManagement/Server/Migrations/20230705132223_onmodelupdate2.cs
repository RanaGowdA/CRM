using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerRelationshipManagement.Server.Migrations
{
    public partial class onmodelupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Opportunities_OpportunityId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Projects_ProjectId1",
                table: "Leads");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId1",
                table: "Leads",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityId",
                table: "Leads",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Opportunities_OpportunityId",
                table: "Leads",
                column: "OpportunityId",
                principalTable: "Opportunities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Projects_ProjectId1",
                table: "Leads",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Opportunities_OpportunityId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Projects_ProjectId1",
                table: "Leads");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId1",
                table: "Leads",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityId",
                table: "Leads",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Opportunities_OpportunityId",
                table: "Leads",
                column: "OpportunityId",
                principalTable: "Opportunities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Projects_ProjectId1",
                table: "Leads",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
