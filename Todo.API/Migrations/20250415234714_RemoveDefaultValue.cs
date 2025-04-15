using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 4, 15, 20, 45, 23, 452, DateTimeKind.Local).AddTicks(4784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 15, 20, 45, 23, 452, DateTimeKind.Local).AddTicks(4784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
