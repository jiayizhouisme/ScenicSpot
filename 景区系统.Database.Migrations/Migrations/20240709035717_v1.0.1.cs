using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 景区系统.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentID",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "父级菜单ID",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "父级菜单ID");

            migrationBuilder.AlterColumn<string>(
                name: "MenuUrl",
                table: "Menu",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                comment: "菜单跳转链接",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "菜单跳转链接");

            migrationBuilder.AlterColumn<string>(
                name: "MenuName",
                table: "Menu",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                comment: "菜单名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "菜单名称");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Menu",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                comment: "菜单图标",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "菜单图标");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                comment: "父级菜单ID",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "父级菜单ID");

            migrationBuilder.AlterColumn<string>(
                name: "MenuUrl",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                comment: "菜单跳转链接",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "菜单跳转链接");

            migrationBuilder.AlterColumn<string>(
                name: "MenuName",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                comment: "菜单名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true,
                oldComment: "菜单名称");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                comment: "菜单图标",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true,
                oldComment: "菜单图标");
        }
    }
}
