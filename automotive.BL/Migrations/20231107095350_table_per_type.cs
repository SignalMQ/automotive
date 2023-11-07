using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace automotive.BL.Migrations
{
    /// <inheritdoc />
    public partial class table_per_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Body_BodyId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Chassis_ChassisId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Engine_EngineId",
                table: "Transports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transports",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_BodyId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_ChassisId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_EngineId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "BodyId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "ChassisId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Transports");

            migrationBuilder.RenameTable(
                name: "Transports",
                newName: "Car");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Car",
                newName: "Clearance");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Mileage = table.Column<int>(type: "INTEGER", nullable: false),
                    EngineId = table.Column<int>(type: "INTEGER", nullable: false),
                    ChassisId = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transport_Body_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Body",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jeep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Clearance = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jeep_Transport_Id",
                        column: x => x.Id,
                        principalTable: "Transport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moto_Transport_Id",
                        column: x => x.Id,
                        principalTable: "Transport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transport_BodyId",
                table: "Transport",
                column: "BodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_ChassisId",
                table: "Transport",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_EngineId",
                table: "Transport",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transport_Id",
                table: "Car",
                column: "Id",
                principalTable: "Transport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transport_Id",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Jeep");

            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Transports");

            migrationBuilder.RenameColumn(
                name: "Clearance",
                table: "Transports",
                newName: "Year");

            migrationBuilder.AddColumn<int>(
                name: "BodyId",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChassisId",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Transports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Transports",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Transports",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transports",
                table: "Transports",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_BodyId",
                table: "Transports",
                column: "BodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_ChassisId",
                table: "Transports",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_EngineId",
                table: "Transports",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Body_BodyId",
                table: "Transports",
                column: "BodyId",
                principalTable: "Body",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Chassis_ChassisId",
                table: "Transports",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Engine_EngineId",
                table: "Transports",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
