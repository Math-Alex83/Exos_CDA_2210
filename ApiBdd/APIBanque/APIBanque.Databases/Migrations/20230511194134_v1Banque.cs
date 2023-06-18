using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBanque.Databases.Migrations
{
    /// <inheritdoc />
    public partial class v1Banque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankTransactions",
                columns: table => new
                {
                    transaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    transaction_from = table.Column<long>(type: "bigint", nullable: false),
                    transaction_to = table.Column<long>(type: "bigint", nullable: false),
                    transaction_amount = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactions", x => x.transaction_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankTransactions");
        }
    }
}
