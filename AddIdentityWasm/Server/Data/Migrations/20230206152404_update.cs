using Microsoft.EntityFrameworkCore.Migrations;

namespace AddIdentityWasm.Server.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "productPrice",
                table: "Products",
                type: "DECIMAL(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "productUrl",
                table: "Products",
                type: "VARCHAR(250)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "Categories",
                type: "INT",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "SMALLINT");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Categories",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productUrl",
                table: "Products");

            migrationBuilder.AlterColumn<short>(
                name: "type",
                table: "Categories",
                type: "SMALLINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Categories",
                type: "VARCHAR(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
