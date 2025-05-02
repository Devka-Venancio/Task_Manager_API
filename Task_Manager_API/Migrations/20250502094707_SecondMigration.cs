using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Manager_API.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tasks",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tasks",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tasks",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "EditDate",
                table: "tasks",
                newName: "edit_date");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "tasks",
                newName: "create_date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "tasks",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "tasks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "tasks",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "edit_date",
                table: "tasks",
                newName: "EditDate");

            migrationBuilder.RenameColumn(
                name: "create_date",
                table: "tasks",
                newName: "CreateDate");
        }
    }
}
