using Microsoft.EntityFrameworkCore.Migrations;

namespace Heaven.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Utilizator_UtilizatorId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_UtilizatorId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UtilizatorId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Utilizator",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "oras",
                table: "Adaposts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "denumire",
                table: "Adaposts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "adresa",
                table: "Adaposts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizator_ContactId",
                table: "Utilizator",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilizator_Contact_ContactId",
                table: "Utilizator",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizator_Contact_ContactId",
                table: "Utilizator");

            migrationBuilder.DropIndex(
                name: "IX_Utilizator_ContactId",
                table: "Utilizator");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Utilizator");

            migrationBuilder.AddColumn<int>(
                name: "UtilizatorId",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "oras",
                table: "Adaposts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "denumire",
                table: "Adaposts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "adresa",
                table: "Adaposts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UtilizatorId",
                table: "Contact",
                column: "UtilizatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Utilizator_UtilizatorId",
                table: "Contact",
                column: "UtilizatorId",
                principalTable: "Utilizator",
                principalColumn: "UtilizatorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
