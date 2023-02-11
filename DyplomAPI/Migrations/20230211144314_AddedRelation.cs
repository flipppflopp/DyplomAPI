using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DyplomAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseID",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "VolonteerID",
                table: "OrganizationMembers",
                newName: "VolonteerInfoID");

            migrationBuilder.RenameColumn(
                name: "Volonteer_ID",
                table: "Expenses",
                newName: "VolonteerInfoID");

            migrationBuilder.RenameColumn(
                name: "VolonteerID",
                table: "Advertisements",
                newName: "VolonteerInfoID");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdvertisementExpense",
                columns: table => new
                {
                    AdvertisementsID = table.Column<int>(type: "int", nullable: false),
                    ExpensesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementExpense", x => new { x.AdvertisementsID, x.ExpensesID });
                    table.ForeignKey(
                        name: "FK_AdvertisementExpense_Advertisements_AdvertisementsID",
                        column: x => x.AdvertisementsID,
                        principalTable: "Advertisements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementExpense_Expenses_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expenses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolonteerInfos_UserID",
                table: "VolonteerInfos",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMembers_OrganizationID",
                table: "OrganizationMembers",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMembers_VolonteerInfoID",
                table: "OrganizationMembers",
                column: "VolonteerInfoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_VolonteerInfoID",
                table: "Expenses",
                column: "VolonteerInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_VolonteerInfoID",
                table: "Advertisements",
                column: "VolonteerInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementExpense_ExpensesID",
                table: "AdvertisementExpense",
                column: "ExpensesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_VolonteerInfos_VolonteerInfoID",
                table: "Advertisements",
                column: "VolonteerInfoID",
                principalTable: "VolonteerInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_VolonteerInfos_VolonteerInfoID",
                table: "Expenses",
                column: "VolonteerInfoID",
                principalTable: "VolonteerInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationMembers_Organizations_OrganizationID",
                table: "OrganizationMembers",
                column: "OrganizationID",
                principalTable: "Organizations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationMembers_VolonteerInfos_VolonteerInfoID",
                table: "OrganizationMembers",
                column: "VolonteerInfoID",
                principalTable: "VolonteerInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VolonteerInfos_Users_UserID",
                table: "VolonteerInfos",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_VolonteerInfos_VolonteerInfoID",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_VolonteerInfos_VolonteerInfoID",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationMembers_Organizations_OrganizationID",
                table: "OrganizationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationMembers_VolonteerInfos_VolonteerInfoID",
                table: "OrganizationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_VolonteerInfos_Users_UserID",
                table: "VolonteerInfos");

            migrationBuilder.DropTable(
                name: "AdvertisementExpense");

            migrationBuilder.DropIndex(
                name: "IX_VolonteerInfos_UserID",
                table: "VolonteerInfos");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationMembers_OrganizationID",
                table: "OrganizationMembers");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationMembers_VolonteerInfoID",
                table: "OrganizationMembers");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_VolonteerInfoID",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_VolonteerInfoID",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "VolonteerInfoID",
                table: "OrganizationMembers",
                newName: "VolonteerID");

            migrationBuilder.RenameColumn(
                name: "VolonteerInfoID",
                table: "Expenses",
                newName: "Volonteer_ID");

            migrationBuilder.RenameColumn(
                name: "VolonteerInfoID",
                table: "Advertisements",
                newName: "VolonteerID");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseID",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
