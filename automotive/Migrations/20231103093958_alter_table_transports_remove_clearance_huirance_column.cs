using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace automotive.Migrations
{
    /// <inheritdoc />
    public partial class alter_table_transports_remove_clearance_huirance_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clearance",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "Huirence",
                table: "Transports");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Clearance",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Huirence",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
