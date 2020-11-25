using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiGhe",
                columns: table => new
                {
                    IDLG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaLG = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiGhe", x => x.IDLG);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTK",
                columns: table => new
                {
                    IDLTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLTK = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTK", x => x.IDLTK);
                });

            migrationBuilder.CreateTable(
                name: "ThanhPho",
                columns: table => new
                {
                    IDTP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhPho", x => x.IDTP);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    IDTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLTK = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.IDTK);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_LoaiTK_IDLTK",
                        column: x => x.IDLTK,
                        principalTable: "LoaiTK",
                        principalColumn: "IDLTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rap",
                columns: table => new
                {
                    IDRap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDTP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rap", x => x.IDRap);
                    table.ForeignKey(
                        name: "FK_Rap_ThanhPho_IDTP",
                        column: x => x.IDTP,
                        principalTable: "ThanhPho",
                        principalColumn: "IDTP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IDHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTK = table.Column<int>(type: "int", nullable: false),
                    IDRap = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IDHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_Rap_IDRap",
                        column: x => x.IDRap,
                        principalTable: "Rap",
                        principalColumn: "IDRap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_TaiKhoan_IDTK",
                        column: x => x.IDTK,
                        principalTable: "TaiKhoan",
                        principalColumn: "IDTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    IDPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoPhong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDRap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.IDPhong);
                    table.ForeignKey(
                        name: "FK_Phong_Rap_IDRap",
                        column: x => x.IDRap,
                        principalTable: "Rap",
                        principalColumn: "IDRap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    IDCTHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHD = table.Column<int>(type: "int", nullable: false),
                    TenRap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhongChieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenGhe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaLG = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.IDCTHD);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IDHD",
                        column: x => x.IDHD,
                        principalTable: "HoaDon",
                        principalColumn: "IDHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    IDGhe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLG = table.Column<int>(type: "int", nullable: false),
                    IDPhong = table.Column<int>(type: "int", nullable: false),
                    TenGhe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoGhe = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.IDGhe);
                    table.ForeignKey(
                        name: "FK_Ghe_LoaiGhe_IDLG",
                        column: x => x.IDLG,
                        principalTable: "LoaiGhe",
                        principalColumn: "IDLG",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ghe_Phong_IDPhong",
                        column: x => x.IDPhong,
                        principalTable: "Phong",
                        principalColumn: "IDPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    IDPhim = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPhong = table.Column<int>(type: "int", nullable: false),
                    AnhPhim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDienVien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenNgonNgu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TheLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenPhuDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DaoDien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KhoiChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    Rated = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.IDPhim);
                    table.ForeignKey(
                        name: "FK_Phim_Phong_IDPhong",
                        column: x => x.IDPhong,
                        principalTable: "Phong",
                        principalColumn: "IDPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhungGio",
                columns: table => new
                {
                    IDKG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPhim = table.Column<int>(type: "int", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhungGio", x => x.IDKG);
                    table.ForeignKey(
                        name: "FK_KhungGio_Phim_IDPhim",
                        column: x => x.IDPhim,
                        principalTable: "Phim",
                        principalColumn: "IDPhim",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LoaiGhe",
                columns: new[] { "IDLG", "GiaLG", "TenLoai", "TrangThai" },
                values: new object[,]
                {
                    { 1, 50000m, "Thường", 1 },
                    { 2, 55000m, "Vip", 1 },
                    { 3, 60000m, "Đôi", 1 }
                });

            migrationBuilder.InsertData(
                table: "LoaiTK",
                columns: new[] { "IDLTK", "TenLTK", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Thành Viên", 1 },
                    { 2, "Admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "ThanhPho",
                columns: new[] { "IDTP", "TenTP", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Hồ Chí Minh", 1 },
                    { 2, "Hà Nội", 1 },
                    { 3, "Đà Nẵng", 1 },
                    { 4, "Cần Thơ", 1 },
                    { 5, "Đồng Nai", 1 }
                });

            migrationBuilder.InsertData(
                table: "Rap",
                columns: new[] { "IDRap", "IDTP", "TenRap", "TrangThai" },
                values: new object[,]
                {
                    { 1, 1, "Hùng Vương Plaza", 1 },
                    { 2, 1, "CGV Vivo City", 1 },
                    { 3, 1, "CGV Lý Chính Thắng", 1 },
                    { 4, 2, "CGV VimCom Center Bà Triệu", 1 },
                    { 5, 2, "CGV Hồ Gơm Plaza", 1 },
                    { 6, 2, "CGV Aeon Long Biên", 1 },
                    { 7, 3, "CGV Vincom Đà Nẵng", 1 },
                    { 8, 4, "CGV Cần Thơ Plaza", 1 },
                    { 9, 5, "CGV Big C Đồng Nai", 1 },
                    { 10, 5, "CGV Coopmart Biên Hòa", 1 }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "IDTK", "AnhDaiDien", "DiaChi", "DienThoai", "Email", "GioiTinh", "Ho", "IDLTK", "MatKhau", "NgaySinh", "TaiKhoan", "Ten", "TrangThai" },
                values: new object[] { 1, "1.jpg", "Tây Ninh", "0326440254", "vtvantrong272@gmail.com", "Nam", "Nguyễn Văn", 2, "Admin", new DateTime(2000, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Trọng", 1 });

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "IDPhong", "IDRap", "SoPhong", "TrangThai" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 28, 6, 3, 1 },
                    { 29, 6, 4, 1 },
                    { 30, 6, 5, 1 },
                    { 31, 7, 1, 1 },
                    { 32, 7, 2, 1 },
                    { 33, 7, 3, 1 },
                    { 34, 7, 4, 1 },
                    { 35, 7, 5, 1 },
                    { 36, 8, 1, 1 },
                    { 37, 8, 2, 1 },
                    { 38, 8, 3, 1 },
                    { 39, 8, 4, 1 },
                    { 40, 8, 5, 1 },
                    { 41, 9, 1, 1 },
                    { 42, 9, 2, 1 },
                    { 43, 9, 3, 1 },
                    { 44, 9, 4, 1 },
                    { 45, 9, 5, 1 },
                    { 46, 10, 1, 1 },
                    { 47, 10, 2, 1 },
                    { 48, 10, 3, 1 },
                    { 27, 6, 2, 1 },
                    { 26, 6, 1, 1 },
                    { 25, 5, 5, 1 },
                    { 24, 5, 4, 1 },
                    { 2, 1, 2, 1 },
                    { 3, 1, 3, 1 },
                    { 4, 1, 4, 1 },
                    { 5, 1, 5, 1 },
                    { 6, 2, 1, 1 },
                    { 7, 2, 2, 1 },
                    { 8, 2, 3, 1 },
                    { 9, 2, 4, 1 },
                    { 10, 2, 5, 1 },
                    { 11, 3, 1, 1 },
                    { 49, 10, 4, 1 },
                    { 12, 3, 2, 1 },
                    { 14, 3, 4, 1 },
                    { 15, 3, 5, 1 },
                    { 16, 4, 1, 1 },
                    { 17, 4, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "IDPhong", "IDRap", "SoPhong", "TrangThai" },
                values: new object[,]
                {
                    { 18, 4, 3, 1 },
                    { 19, 4, 4, 1 },
                    { 20, 4, 5, 1 },
                    { 21, 5, 1, 1 },
                    { 22, 5, 2, 1 },
                    { 23, 5, 3, 1 },
                    { 13, 3, 3, 1 },
                    { 50, 10, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, "A", 1 },
                    { 146, 1, 4, 8, "A", 1 },
                    { 147, 1, 4, 1, "B", 1 },
                    { 148, 1, 4, 2, "B", 1 },
                    { 149, 1, 4, 3, "B", 1 },
                    { 150, 1, 4, 4, "B", 1 },
                    { 151, 1, 4, 5, "B", 1 },
                    { 152, 1, 4, 6, "B", 1 },
                    { 153, 1, 4, 7, "B", 1 },
                    { 154, 1, 4, 8, "B", 1 },
                    { 155, 1, 4, 1, "C", 1 },
                    { 156, 1, 4, 2, "C", 1 },
                    { 157, 1, 4, 3, "C", 1 },
                    { 158, 1, 4, 4, "C", 1 },
                    { 159, 1, 4, 5, "C", 1 },
                    { 160, 1, 4, 6, "C", 1 },
                    { 161, 1, 4, 7, "C", 1 },
                    { 162, 1, 4, 8, "C", 1 },
                    { 163, 2, 4, 1, "D", 1 },
                    { 164, 2, 4, 2, "D", 1 },
                    { 165, 2, 4, 3, "D", 1 },
                    { 166, 2, 4, 4, "D", 1 },
                    { 167, 2, 4, 5, "D", 1 },
                    { 168, 2, 4, 6, "D", 1 },
                    { 169, 2, 4, 7, "D", 1 },
                    { 170, 2, 4, 8, "D", 1 },
                    { 145, 1, 4, 7, "A", 1 },
                    { 171, 2, 4, 1, "E", 1 },
                    { 144, 1, 4, 6, "A", 1 },
                    { 142, 1, 4, 4, "A", 1 },
                    { 117, 2, 3, 1, "D", 1 },
                    { 118, 2, 3, 2, "D", 1 },
                    { 119, 2, 3, 3, "D", 1 },
                    { 120, 2, 3, 4, "D", 1 },
                    { 121, 2, 3, 5, "D", 1 },
                    { 122, 2, 3, 6, "D", 1 },
                    { 123, 2, 3, 7, "D", 1 },
                    { 124, 2, 3, 8, "D", 1 },
                    { 125, 2, 3, 1, "E", 1 },
                    { 126, 2, 3, 2, "E", 1 },
                    { 127, 2, 3, 3, "E", 1 },
                    { 128, 2, 3, 4, "E", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 129, 2, 3, 5, "E", 1 },
                    { 130, 2, 3, 6, "E", 1 },
                    { 131, 2, 3, 7, "E", 1 },
                    { 132, 2, 3, 8, "E", 1 },
                    { 133, 3, 3, 1, "F", 1 },
                    { 134, 3, 3, 2, "F", 1 },
                    { 135, 3, 3, 3, "F", 1 },
                    { 136, 3, 3, 4, "F", 1 },
                    { 137, 3, 3, 5, "F", 1 },
                    { 138, 3, 3, 6, "F", 1 },
                    { 139, 1, 4, 1, "A", 1 },
                    { 140, 1, 4, 2, "A", 1 },
                    { 141, 1, 4, 3, "A", 1 },
                    { 143, 1, 4, 5, "A", 1 },
                    { 172, 2, 4, 2, "E", 1 },
                    { 173, 2, 4, 3, "E", 1 },
                    { 174, 2, 4, 4, "E", 1 },
                    { 205, 1, 5, 5, "C", 1 },
                    { 206, 1, 5, 6, "C", 1 },
                    { 207, 1, 5, 7, "C", 1 },
                    { 208, 1, 5, 8, "C", 1 },
                    { 209, 2, 5, 1, "D", 1 },
                    { 210, 2, 5, 2, "D", 1 },
                    { 211, 2, 5, 3, "D", 1 },
                    { 212, 2, 5, 4, "D", 1 },
                    { 213, 2, 5, 5, "D", 1 },
                    { 214, 2, 5, 6, "D", 1 },
                    { 215, 2, 5, 7, "D", 1 },
                    { 216, 2, 5, 8, "D", 1 },
                    { 217, 2, 5, 1, "E", 1 },
                    { 218, 2, 5, 2, "E", 1 },
                    { 219, 2, 5, 3, "E", 1 },
                    { 220, 2, 5, 4, "E", 1 },
                    { 221, 2, 5, 5, "E", 1 },
                    { 222, 2, 5, 6, "E", 1 },
                    { 223, 2, 5, 7, "E", 1 },
                    { 224, 2, 5, 8, "E", 1 },
                    { 225, 3, 5, 1, "F", 1 },
                    { 226, 3, 5, 2, "F", 1 },
                    { 227, 3, 5, 3, "F", 1 },
                    { 228, 3, 5, 4, "F", 1 },
                    { 229, 3, 5, 5, "F", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 204, 1, 5, 4, "C", 1 },
                    { 203, 1, 5, 3, "C", 1 },
                    { 202, 1, 5, 2, "C", 1 },
                    { 201, 1, 5, 1, "C", 1 },
                    { 175, 2, 4, 5, "E", 1 },
                    { 176, 2, 4, 6, "E", 1 },
                    { 177, 2, 4, 7, "E", 1 },
                    { 178, 2, 4, 8, "E", 1 },
                    { 179, 3, 4, 1, "F", 1 },
                    { 180, 3, 4, 2, "F", 1 },
                    { 181, 3, 4, 3, "F", 1 },
                    { 182, 3, 4, 4, "F", 1 },
                    { 183, 3, 4, 5, "F", 1 },
                    { 184, 3, 4, 6, "F", 1 },
                    { 185, 1, 5, 1, "A", 1 },
                    { 186, 1, 5, 2, "A", 1 },
                    { 230, 3, 5, 6, "F", 1 },
                    { 187, 1, 5, 3, "A", 1 },
                    { 189, 1, 5, 5, "A", 1 },
                    { 190, 1, 5, 6, "A", 1 },
                    { 191, 1, 5, 7, "A", 1 },
                    { 192, 1, 5, 8, "A", 1 },
                    { 193, 1, 5, 1, "B", 1 },
                    { 194, 1, 5, 2, "B", 1 },
                    { 195, 1, 5, 3, "B", 1 },
                    { 196, 1, 5, 4, "B", 1 },
                    { 197, 1, 5, 5, "B", 1 },
                    { 198, 1, 5, 6, "B", 1 },
                    { 199, 1, 5, 7, "B", 1 },
                    { 200, 1, 5, 8, "B", 1 },
                    { 188, 1, 5, 4, "A", 1 },
                    { 115, 1, 3, 7, "C", 1 },
                    { 116, 1, 3, 8, "C", 1 },
                    { 113, 1, 3, 5, "C", 1 },
                    { 31, 2, 1, 7, "D", 1 },
                    { 32, 2, 1, 8, "D", 1 },
                    { 33, 2, 1, 1, "E", 1 },
                    { 34, 2, 1, 2, "E", 1 },
                    { 35, 2, 1, 3, "E", 1 },
                    { 36, 2, 1, 4, "E", 1 },
                    { 37, 2, 1, 5, "E", 1 },
                    { 38, 2, 1, 6, "E", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 39, 2, 1, 7, "E", 1 },
                    { 40, 2, 1, 8, "E", 1 },
                    { 41, 3, 1, 1, "F", 1 },
                    { 42, 3, 1, 2, "F", 1 },
                    { 43, 3, 1, 3, "F", 1 },
                    { 44, 3, 1, 4, "F", 1 },
                    { 45, 3, 1, 5, "F", 1 },
                    { 46, 3, 1, 6, "F", 1 },
                    { 47, 1, 2, 1, "A", 1 },
                    { 48, 1, 2, 2, "A", 1 },
                    { 49, 1, 2, 3, "A", 1 },
                    { 50, 1, 2, 4, "A", 1 },
                    { 51, 1, 2, 5, "A", 1 },
                    { 52, 1, 2, 6, "A", 1 },
                    { 53, 1, 2, 7, "A", 1 },
                    { 54, 1, 2, 8, "A", 1 },
                    { 55, 1, 2, 1, "B", 1 },
                    { 30, 2, 1, 6, "D", 1 },
                    { 56, 1, 2, 2, "B", 1 },
                    { 29, 2, 1, 5, "D", 1 },
                    { 27, 2, 1, 3, "D", 1 },
                    { 2, 1, 1, 2, "A", 1 },
                    { 3, 1, 1, 3, "A", 1 },
                    { 4, 1, 1, 4, "A", 1 },
                    { 5, 1, 1, 5, "A", 1 },
                    { 6, 1, 1, 6, "A", 1 },
                    { 7, 1, 1, 7, "A", 1 },
                    { 8, 1, 1, 8, "A", 1 },
                    { 9, 1, 1, 1, "B", 1 },
                    { 10, 1, 1, 2, "B", 1 },
                    { 11, 1, 1, 3, "B", 1 },
                    { 12, 1, 1, 4, "B", 1 },
                    { 13, 1, 1, 5, "B", 1 },
                    { 14, 1, 1, 6, "B", 1 },
                    { 15, 1, 1, 7, "B", 1 },
                    { 16, 1, 1, 8, "B", 1 },
                    { 17, 1, 1, 1, "C", 1 },
                    { 18, 1, 1, 2, "C", 1 },
                    { 19, 1, 1, 3, "C", 1 },
                    { 20, 1, 1, 4, "C", 1 },
                    { 21, 1, 1, 5, "C", 1 },
                    { 22, 1, 1, 6, "C", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 23, 1, 1, 7, "C", 1 },
                    { 24, 1, 1, 8, "C", 1 },
                    { 25, 2, 1, 1, "D", 1 },
                    { 26, 2, 1, 2, "D", 1 },
                    { 28, 2, 1, 4, "D", 1 },
                    { 114, 1, 3, 6, "C", 1 },
                    { 57, 1, 2, 3, "B", 1 },
                    { 59, 1, 2, 5, "B", 1 },
                    { 88, 3, 2, 2, "F", 1 },
                    { 89, 3, 2, 3, "F", 1 },
                    { 90, 3, 2, 4, "F", 1 },
                    { 91, 3, 2, 5, "F", 1 },
                    { 92, 3, 2, 6, "F", 1 },
                    { 93, 1, 3, 1, "A", 1 },
                    { 94, 1, 3, 2, "A", 1 },
                    { 95, 1, 3, 3, "A", 1 },
                    { 96, 1, 3, 4, "A", 1 },
                    { 97, 1, 3, 5, "A", 1 },
                    { 98, 1, 3, 6, "A", 1 },
                    { 99, 1, 3, 7, "A", 1 },
                    { 100, 1, 3, 8, "A", 1 },
                    { 101, 1, 3, 1, "B", 1 },
                    { 102, 1, 3, 2, "B", 1 },
                    { 103, 1, 3, 3, "B", 1 },
                    { 104, 1, 3, 4, "B", 1 },
                    { 105, 1, 3, 5, "B", 1 },
                    { 106, 1, 3, 6, "B", 1 },
                    { 107, 1, 3, 7, "B", 1 },
                    { 108, 1, 3, 8, "B", 1 },
                    { 109, 1, 3, 1, "C", 1 },
                    { 110, 1, 3, 2, "C", 1 },
                    { 111, 1, 3, 3, "C", 1 },
                    { 112, 1, 3, 4, "C", 1 },
                    { 87, 3, 2, 1, "F", 1 },
                    { 58, 1, 2, 4, "B", 1 },
                    { 86, 2, 2, 8, "E", 1 },
                    { 84, 2, 2, 6, "E", 1 },
                    { 60, 1, 2, 6, "B", 1 },
                    { 61, 1, 2, 7, "B", 1 },
                    { 62, 1, 2, 8, "B", 1 },
                    { 63, 1, 2, 1, "C", 1 },
                    { 64, 1, 2, 2, "C", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ghe",
                columns: new[] { "IDGhe", "IDLG", "IDPhong", "SoGhe", "TenGhe", "TrangThai" },
                values: new object[,]
                {
                    { 65, 1, 2, 3, "C", 1 },
                    { 66, 1, 2, 4, "C", 1 },
                    { 67, 1, 2, 5, "C", 1 },
                    { 68, 1, 2, 6, "C", 1 },
                    { 69, 1, 2, 7, "C", 1 },
                    { 70, 1, 2, 8, "C", 1 },
                    { 85, 2, 2, 7, "E", 1 },
                    { 72, 2, 2, 2, "D", 1 },
                    { 71, 2, 2, 1, "D", 1 },
                    { 74, 2, 2, 4, "D", 1 },
                    { 75, 2, 2, 5, "D", 1 },
                    { 76, 2, 2, 6, "D", 1 },
                    { 77, 2, 2, 7, "D", 1 },
                    { 78, 2, 2, 8, "D", 1 },
                    { 79, 2, 2, 1, "E", 1 },
                    { 80, 2, 2, 2, "E", 1 },
                    { 81, 2, 2, 3, "E", 1 },
                    { 82, 2, 2, 4, "E", 1 },
                    { 83, 2, 2, 5, "E", 1 },
                    { 73, 2, 2, 3, "D", 1 }
                });

            migrationBuilder.InsertData(
                table: "Phim",
                columns: new[] { "IDPhim", "AnhPhim", "DaoDien", "IDPhong", "KhoiChieu", "Rated", "TenDienVien", "TenNgonNgu", "TenPhim", "TenPhuDe", "TheLoai", "ThoiLuong", "TrangThai" },
                values: new object[,]
                {
                    { 4, "1.jpg", "Nguyễn Hữu Tiến", 4, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Yaya Trương Nhi, Trịnh Xuân Nhãn, Phạm Thanh Trúc, Tú Hảo", "Tiếng Việt", "CHỒNG NGƯỜI TA", "Tiếng Anh", "Tâm Lý", 91, 1 },
                    { 1, "1.jpg", "Tạ Nguyên Hiệp", 1, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Hoàng Thùy Linh, B Trần, Hứa Vĩ Văn, Trịnh Thăng Bình, Hạnh Thúy, Kay Trần", "Tiếng Việt", "TRÁI TIM QUÁI VẬT", "Tiếng Anh", "Hồi hộp, Tâm Lý", 89, 1 },
                    { 2, "1.jpg", "Aneesh Chaganty", 2, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Sarah Paulson, Kiera Allen", "Tiếng Việt", "TRỐN CHẠY", "Tiếng Anh", "Hồi hộp, Tâm Lý", 90, 1 },
                    { 3, "1.jpg", "Kim Ji-hoon", 3, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Sul Kyung-Gu, Son Ye-Jin, Kim Sang-Kyung, Kim In-Kwon, Do Ji-Han, Cha In-Pyo", "Tiếng Hàn", "THÁP LỬA", "Tiếng Việt", "Hành Động", 121, 1 },
                    { 5, "1.jpg", "Nguyễn Quang Dũng", 5, new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Thái Hoà, Đức Thịnh, Hồng Ánh, Hứa Vỹ Văn , Thu Trang, Kiều Minh Tuấn, Kaity Nguyễn", "Tiếng Việt", "TIỆC TRĂNG MÁU", "Tiếng Anh", "Hài, Tâm Lý", 118, 1 }
                });

            migrationBuilder.InsertData(
                table: "KhungGio",
                columns: new[] { "IDKG", "IDPhim", "ThoiGian", "TrangThai" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2020, 11, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, new DateTime(2020, 11, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 2, new DateTime(2020, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 3, new DateTime(2020, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 4, new DateTime(2020, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 5, new DateTime(2020, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IDHD",
                table: "ChiTietHoaDon",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_IDLG",
                table: "Ghe",
                column: "IDLG");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_IDPhong",
                table: "Ghe",
                column: "IDPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDRap",
                table: "HoaDon",
                column: "IDRap");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDTK",
                table: "HoaDon",
                column: "IDTK");

            migrationBuilder.CreateIndex(
                name: "IX_KhungGio_IDPhim",
                table: "KhungGio",
                column: "IDPhim");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_IDPhong",
                table: "Phim",
                column: "IDPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_IDRap",
                table: "Phong",
                column: "IDRap");

            migrationBuilder.CreateIndex(
                name: "IX_Rap_IDTP",
                table: "Rap",
                column: "IDTP");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IDLTK",
                table: "TaiKhoan",
                column: "IDLTK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropTable(
                name: "KhungGio");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LoaiGhe");

            migrationBuilder.DropTable(
                name: "Phim");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "LoaiTK");

            migrationBuilder.DropTable(
                name: "Rap");

            migrationBuilder.DropTable(
                name: "ThanhPho");
        }
    }
}
