using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoulsDB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "normWeapReinfMultipliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UpgradeLevel = table.Column<byte>(type: "smallint", nullable: false),
                    PhysicalAR = table.Column<float>(type: "real", nullable: false),
                    MagicAR = table.Column<float>(type: "real", nullable: false),
                    FireAR = table.Column<float>(type: "real", nullable: false),
                    LightningAR = table.Column<float>(type: "real", nullable: false),
                    STRScaling = table.Column<float>(type: "real", nullable: false),
                    DEXScaling = table.Column<float>(type: "real", nullable: false),
                    INTScaling = table.Column<float>(type: "real", nullable: false),
                    FAIScaling = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_normWeapReinfMultipliers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "normWeapReinfMultipliers");
        }
    }
}
