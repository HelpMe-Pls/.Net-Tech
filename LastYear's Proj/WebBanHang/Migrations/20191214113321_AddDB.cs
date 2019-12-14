using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiViet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TieuDe = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    Hinh = table.Column<string>(nullable: true),
                    MaLoai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiViet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    MaLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.MaLoai);
                });

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

            migrationBuilder.CreateTable(
                name: "QuangCao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hinh = table.Column<string>(nullable: true),
                    MaHH = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuangCao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTK = table.Column<string>(nullable: false),
                    TenDangNhap = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.MaTK);
                });

            migrationBuilder.CreateTable(
                name: "HangHoa",
                columns: table => new
                {
                    MaHH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHH = table.Column<string>(maxLength: 100, nullable: false),
                    Hinh = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    DonGia = table.Column<double>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    MaLoai = table.Column<int>(nullable: false),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    GiamGia = table.Column<int>(nullable: false),
                    DaMua = table.Column<int>(nullable: false),
                    NoiBat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoa", x => x.MaHH);
                    table.ForeignKey(
                        name: "FK_HangHoa_Loai_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "Loai",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OderDetail",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Gia = table.Column<double>(nullable: false),
                    MaHH = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OderDetail_Oder_OderID",
                        column: x => x.OderID,
                        principalTable: "Oder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HangHoa_MaLoai",
                table: "HangHoa",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_OderDetail_OderID",
                table: "OderDetail",
                column: "OderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiViet");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "HangHoa");

            migrationBuilder.DropTable(
                name: "OderDetail");

            migrationBuilder.DropTable(
                name: "QuangCao");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "Oder");
        }
    }
}
