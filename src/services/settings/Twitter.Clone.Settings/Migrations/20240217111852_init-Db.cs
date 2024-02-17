using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Clone.Settings.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "BlockedListSettingSequence");

            migrationBuilder.CreateSequence(
                name: "NotificationSettingSequence");

            migrationBuilder.CreateTable(
                name: "BlockedPages",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "NEXT VALUE FOR [BlockedListSettingSequence]"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlockedPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlockedUsers",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "NEXT VALUE FOR [BlockedListSettingSequence]"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlockedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "NEXT VALUE FOR [NotificationSettingSequence]"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsMentionActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDirectMessageActive = table.Column<bool>(type: "bit", nullable: false),
                    IsFollowActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailNotificationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "NEXT VALUE FOR [NotificationSettingSequence]"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPasswordChangeActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsNotificationSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlockedPages_Id",
                table: "BlockedPages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BlockedUsers_Id",
                table: "BlockedUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmailNotificationSettings_Id",
                table: "EmailNotificationSettings",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SmsNotificationSettings_Id",
                table: "SmsNotificationSettings",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockedPages");

            migrationBuilder.DropTable(
                name: "BlockedUsers");

            migrationBuilder.DropTable(
                name: "EmailNotificationSettings");

            migrationBuilder.DropTable(
                name: "SmsNotificationSettings");

            migrationBuilder.DropSequence(
                name: "BlockedListSettingSequence");

            migrationBuilder.DropSequence(
                name: "NotificationSettingSequence");
        }
    }
}
