using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Clone.Trends.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddIPAddressColumnInHashtagEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                schema: "trends",
                table: "HashTagEntries",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPAddress",
                schema: "trends",
                table: "HashTagEntries");
        }
    }
}
