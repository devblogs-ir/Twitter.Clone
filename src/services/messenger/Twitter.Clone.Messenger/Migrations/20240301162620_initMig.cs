using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Clone.Messenger.Migrations
{
    /// <inheritdoc />
    public partial class initMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivateChats",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StarterUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeletedForStarter = table.Column<bool>(type: "bit", nullable: false),
                    IsDeletedForTarget = table.Column<bool>(type: "bit", nullable: false),
                    ChatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastMessageBrief = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnseenNumbers = table.Column<byte>(type: "tinyint", nullable: false),
                    LastMessageDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateChats", x => x.ChatId);
                });

            migrationBuilder.CreateTable(
                name: "PublicChats",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastMessageBrief = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnseenNumbers = table.Column<byte>(type: "tinyint", nullable: false),
                    LastMessageDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicChats", x => x.ChatId);
                });

            migrationBuilder.CreateTable(
                name: "PrivateMessages",
                columns: table => new
                {
                    PrivateMessageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsForStarter = table.Column<bool>(type: "bit", nullable: false),
                    MessageStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDeletedForStarter = table.Column<bool>(type: "bit", nullable: false),
                    IsDeletedForTarget = table.Column<bool>(type: "bit", nullable: false),
                    DeliverDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    PrivateChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateMessages", x => x.PrivateMessageId);
                    table.ForeignKey(
                        name: "FK_PrivateMessages_PrivateChats_PrivateChatId",
                        column: x => x.PrivateChatId,
                        principalTable: "PrivateChats",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageOwner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicMessages_PublicChats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "PublicChats",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicChatChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Participants_PublicChats_PublicChatChatId",
                        column: x => x.PublicChatChatId,
                        principalTable: "PublicChats",
                        principalColumn: "ChatId");
                    table.ForeignKey(
                        name: "FK_Participants_PublicMessages_PublicMessageId",
                        column: x => x.PublicMessageId,
                        principalTable: "PublicMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicMessageStatus",
                columns: table => new
                {
                    PublicMessageStatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SentMessageSatus = table.Column<byte>(type: "tinyint", nullable: false),
                    DeliverDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicMessageStatus", x => x.PublicMessageStatusId);
                    table.ForeignKey(
                        name: "FK_PublicMessageStatus_PublicMessages_PublicMessageId",
                        column: x => x.PublicMessageId,
                        principalTable: "PublicMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_PublicChatChatId",
                table: "Participants",
                column: "PublicChatChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_PublicMessageId",
                table: "Participants",
                column: "PublicMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_PrivateChatId",
                table: "PrivateMessages",
                column: "PrivateChatId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicMessages_ChatId",
                table: "PublicMessages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicMessageStatus_PublicMessageId",
                table: "PublicMessageStatus",
                column: "PublicMessageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "PrivateMessages");

            migrationBuilder.DropTable(
                name: "PublicMessageStatus");

            migrationBuilder.DropTable(
                name: "PrivateChats");

            migrationBuilder.DropTable(
                name: "PublicMessages");

            migrationBuilder.DropTable(
                name: "PublicChats");
        }
    }
}
