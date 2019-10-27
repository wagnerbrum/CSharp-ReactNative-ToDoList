using Microsoft.EntityFrameworkCore.Migrations;

namespace Todo.Repository.Migrations
{
    public partial class ItemAddChecked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Todos_todoid",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "todoid",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "state",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Todos_todoid",
                table: "Items",
                column: "todoid",
                principalTable: "Todos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Todos_todoid",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "todoid",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Todos_todoid",
                table: "Items",
                column: "todoid",
                principalTable: "Todos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
