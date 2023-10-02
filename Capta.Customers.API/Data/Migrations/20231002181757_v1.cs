using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capta.Customers.API.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerSituation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Situation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSituation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    SituationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_CustomerSituation_SituationId",
                        column: x => x.SituationId,
                        principalTable: "CustomerSituation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_CustomerType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SituationId",
                table: "Customer",
                column: "SituationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TypeId",
                table: "Customer",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerSituation");

            migrationBuilder.DropTable(
                name: "CustomerType");
        }
    }
}
