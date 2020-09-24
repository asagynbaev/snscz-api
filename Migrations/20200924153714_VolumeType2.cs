using Microsoft.EntityFrameworkCore.Migrations;

namespace snscz_api.Migrations
{
    public partial class VolumeType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VolumeTypes_VolumeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VolumeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VolumeId",
                table: "Products");

            migrationBuilder.AddColumn<float>(
                name: "Volume",
                table: "Products",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "VolumeTypeId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_VolumeTypeId",
                table: "Products",
                column: "VolumeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VolumeTypes_VolumeTypeId",
                table: "Products",
                column: "VolumeTypeId",
                principalTable: "VolumeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VolumeTypes_VolumeTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VolumeTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VolumeTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "VolumeId",
                table: "Products",
                type: "integer",
                nullable: true);

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
    }
}
