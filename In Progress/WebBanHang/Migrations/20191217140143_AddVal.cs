using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class AddVal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderDetail_Order_OderID",
                table: "OderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.CreateTable(
                name: "Oder",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    ShipMobile = table.Column<int>(nullable: false),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipEmail = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oder", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OderDetail_Oder_OderID",
                table: "OderDetail",
                column: "OderID",
                principalTable: "Oder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderDetail_Oder_OderID",
                table: "OderDetail");

            migrationBuilder.DropTable(
                name: "Oder");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipEmail = table.Column<string>(nullable: true),
                    ShipMobile = table.Column<int>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OderDetail_Order_OderID",
                table: "OderDetail",
                column: "OderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
