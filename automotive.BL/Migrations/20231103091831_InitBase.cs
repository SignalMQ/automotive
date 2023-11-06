using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace automotive.BL.Migrations
{
    /// <inheritdoc />
    public partial class InitBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Body",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    Material = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Body", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsStarted = table.Column<bool>(type: "INTEGER", nullable: false),
                    FuelLevel = table.Column<double>(type: "REAL", nullable: false),
                    PowerLevel = table.Column<double>(type: "REAL", nullable: false),
                    AntiFreezeLevel = table.Column<double>(type: "REAL", nullable: false),
                    OilLevel = table.Column<double>(type: "REAL", nullable: false),
                    TransmissionOilLevel = table.Column<double>(type: "REAL", nullable: false),
                    BrakeFluidLevel = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wheel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Material = table.Column<string>(type: "TEXT", nullable: true),
                    Diameter = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fuel = table.Column<string>(type: "TEXT", nullable: true),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Capacity = table.Column<double>(type: "REAL", nullable: false),
                    Consumption = table.Column<double>(type: "REAL", nullable: false),
                    CilindersCount = table.Column<int>(type: "INTEGER", nullable: false),
                    StateId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engine_EngineState_StateId",
                        column: x => x.StateId,
                        principalTable: "EngineState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chassis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Material = table.Column<string>(type: "TEXT", nullable: true),
                    WheelCount = table.Column<int>(type: "INTEGER", nullable: false),
                    WheelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chassis_Wheel_WheelId",
                        column: x => x.WheelId,
                        principalTable: "Wheel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
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
                    table.PrimaryKey("PK_Transports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transports_Body_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Body",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_WheelId",
                table: "Chassis",
                column: "WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_StateId",
                table: "Engine",
                column: "StateId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "Body");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Wheel");

            migrationBuilder.DropTable(
                name: "EngineState");
        }
    }
}
