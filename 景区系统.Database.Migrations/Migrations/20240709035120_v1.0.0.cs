using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 景区系统.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "主键ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "菜单名称"),
                    MenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "菜单跳转链接"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序顺序"),
                    ParentID = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "父级菜单ID"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "菜单图标")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
