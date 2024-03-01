using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Clone.Messenger.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_PublicChats_PublicChatChatId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicMessageStatus_PublicMessages_PublicMessageId",
                table: "PublicMessageStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicMessages",
                table: "PublicMessages");

            migrationBuilder.DropColumn(
                name: "PublicMessageId",
                table: "PublicMessages");

            migrationBuilder.DropColumn(
                name: "CanSendMessage",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "IsOwner",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Participants");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublicMessageId",
                table: "PublicMessageStatus",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PublicMessages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PublicChatChatId",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PublicMessageId",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicMessages",
                table: "PublicMessages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_PublicMessageId",
                table: "Participants",
                column: "PublicMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_PublicChats_PublicChatChatId",
                table: "Participants",
                column: "PublicChatChatId",
                principalTable: "PublicChats",
                principalColumn: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_PublicMessages_PublicMessageId",
                table: "Participants",
                column: "PublicMessageId",
                principalTable: "PublicMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicMessageStatus_PublicMessages_PublicMessageId",
                table: "PublicMessageStatus",
                column: "PublicMessageId",
                principalTable: "PublicMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_PublicChats_PublicChatChatId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_PublicMessages_PublicMessageId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicMessageStatus_PublicMessages_PublicMessageId",
                table: "PublicMessageStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicMessages",
                table: "PublicMessages");

            migrationBuilder.DropIndex(
                name: "IX_Participants_PublicMessageId",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PublicMessages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PublicMessageId",
                table: "Participants");

            migrationBuilder.AlterColumn<long>(
                name: "PublicMessageId",
                table: "PublicMessageStatus",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "PublicMessageId",
                table: "PublicMessages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublicChatChatId",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanSendMessage",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Participants",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOwner",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LastName",
                table: "Participants",
                type: "bit",
                maxLength: 20,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicMessages",
                table: "PublicMessages",
                column: "PublicMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_PublicChats_PublicChatChatId",
                table: "Participants",
                column: "PublicChatChatId",
                principalTable: "PublicChats",
                principalColumn: "ChatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicMessageStatus_PublicMessages_PublicMessageId",
                table: "PublicMessageStatus",
                column: "PublicMessageId",
                principalTable: "PublicMessages",
                principalColumn: "PublicMessageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
