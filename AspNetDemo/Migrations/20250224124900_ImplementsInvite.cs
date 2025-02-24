using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetDemo.Migrations
{
    /// <inheritdoc />
    public partial class ImplementsInvite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InvitedByUserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InvitedByUserId",
                table: "Users",
                column: "InvitedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_InvitedByUserId",
                table: "Users",
                column: "InvitedByUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_InvitedByUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InvitedByUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InvitedByUserId",
                table: "Users");
        }
    }
}
