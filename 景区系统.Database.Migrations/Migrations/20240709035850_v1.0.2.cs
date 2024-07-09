using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 景区系统.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "软删除");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Menu");
        }
    }
}
