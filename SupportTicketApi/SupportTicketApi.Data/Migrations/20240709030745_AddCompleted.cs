using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportTicketApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsResolved",
                table: "Tickets",
                newName: "Completed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Completed",
                table: "Tickets",
                newName: "IsResolved");
        }
    }
}
