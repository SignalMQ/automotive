using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace automotive.BL.Migrations
{
    /// <inheritdoc />
    public partial class alter_table_transports_add_column_huirence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Huirence",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Huirence",
                table: "Transports");
        }
    }
}
