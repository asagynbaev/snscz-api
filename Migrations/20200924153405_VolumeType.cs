using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace snscz_api.Migrations
{
    public partial class VolumeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "VolumeId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VolumeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VolumeName = table.Column<string>(nullable: true),
                    VolumeCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolumeTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_VolumeId",
                table: "Products",
                column: "VolumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VolumeTypes_VolumeId",
                table: "Products",
                column: "VolumeId",
                principalTable: "VolumeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VolumeTypes_VolumeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "VolumeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_VolumeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VolumeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
