using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1EFCore2.Migrations
{
    /// <inheritdoc />
    public partial class MoreRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Badges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SessionId",
                table: "Events",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                principalTable: "Attendees",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Sessions_SessionId",
                table: "Events",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_OrganizerId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Sessions_SessionId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_OrganizerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SessionId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Badges");
        }
    }
}
