using Cinema.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Helper
{
    public static class CinemaSeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThanhPhoModel>().HasData(
                new ThanhPhoModel { IDTP = 1, TenTP = "Hồ Chí Minh",TrangThai=1 },
                new ThanhPhoModel { IDTP = 2, TenTP = "Hà Nội", TrangThai = 1 },
                new ThanhPhoModel { IDTP = 3, TenTP = "Đà Nẵng", TrangThai = 1 },
                new ThanhPhoModel { IDTP = 4, TenTP = "Cần Thơ", TrangThai = 1 },
                new ThanhPhoModel { IDTP = 5, TenTP = "Đồng Nai", TrangThai = 1 }
                ) ;
            modelBuilder.Entity<RapModel>().HasData(
                new RapModel { IDRap = 1, IDTP = 1, TenRap = "Hùng Vương Plaza", TrangThai = 1},
                new RapModel { IDRap = 2, IDTP = 1, TenRap = "CGV Vivo City", TrangThai = 1 },
                new RapModel { IDRap = 3, IDTP = 1, TenRap = "CGV Lý Chính Thắng", TrangThai = 1 },
                new RapModel { IDRap = 4, IDTP = 2, TenRap = "CGV VimCom Center Bà Triệu", TrangThai = 1 },
                new RapModel { IDRap = 5, IDTP = 2, TenRap = "CGV Hồ Gơm Plaza", TrangThai = 1 },
                new RapModel { IDRap = 6, IDTP = 2, TenRap = "CGV Aeon Long Biên", TrangThai = 1 },
                new RapModel { IDRap = 7, IDTP = 3, TenRap = "CGV Vincom Đà Nẵng", TrangThai = 1 },
                new RapModel { IDRap = 8, IDTP = 4, TenRap = "CGV Cần Thơ Plaza", TrangThai = 1 },
                new RapModel { IDRap = 9, IDTP = 5, TenRap = "CGV Big C Đồng Nai", TrangThai = 1 },
                new RapModel { IDRap = 10, IDTP = 5, TenRap = "CGV Coopmart Biên Hòa", TrangThai = 1 }
                );
            modelBuilder.Entity<PhongModel>().HasData(
                new PhongModel { IDPhong = 1, IDRap = 1, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 2, IDRap = 1, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 3, IDRap = 1, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 4, IDRap = 1, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 5, IDRap = 1, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 6, IDRap = 2, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 7, IDRap = 2, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 8, IDRap = 2, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 9, IDRap = 2, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 10, IDRap = 2, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 11, IDRap = 3, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 12, IDRap = 3, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 13, IDRap = 3, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 14, IDRap = 3, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 15, IDRap = 3, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 16, IDRap = 4, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 17, IDRap = 4, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 18, IDRap = 4, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 19, IDRap = 4, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 20, IDRap = 4, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 21, IDRap = 5, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 22, IDRap = 5, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 23, IDRap = 5, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 24, IDRap = 5, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 25, IDRap = 5, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 26, IDRap = 6, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 27, IDRap = 6, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 28, IDRap = 6, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 29, IDRap = 6, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 30, IDRap = 6, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 31, IDRap = 7, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 32, IDRap = 7, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 33, IDRap = 7, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 34, IDRap = 7, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 35, IDRap = 7, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 36, IDRap = 8, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 37, IDRap = 8, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 38, IDRap = 8, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 39, IDRap = 8, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 40, IDRap = 8, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 41, IDRap = 9, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 42, IDRap = 9, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 43, IDRap = 9, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 44, IDRap = 9, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 45, IDRap = 9, SoPhong = 5, TrangThai = 1 },

                new PhongModel { IDPhong = 46, IDRap = 10, SoPhong = 1, TrangThai = 1 },
                new PhongModel { IDPhong = 47, IDRap = 10, SoPhong = 2, TrangThai = 1 },
                new PhongModel { IDPhong = 48, IDRap = 10, SoPhong = 3, TrangThai = 1 },
                new PhongModel { IDPhong = 49, IDRap = 10, SoPhong = 4, TrangThai = 1 },
                new PhongModel { IDPhong = 50, IDRap = 10, SoPhong = 5, TrangThai = 1 }
                
                ) ;

            modelBuilder.Entity<LoaiGheModel>().HasData(
                new LoaiGheModel { IDLG = 1, TenLoai = "Thường", GiaLG = 50000, TrangThai = 1 },
                new LoaiGheModel { IDLG = 2, TenLoai = "Vip", GiaLG = 55000, TrangThai = 1 },
                new LoaiGheModel { IDLG = 3, TenLoai = "Đôi", GiaLG = 60000, TrangThai = 1 }
                );


            modelBuilder.Entity<GheModel>().HasData(
                new GheModel { IDGhe = 1, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 2, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 3, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 4, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 5, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 6, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 7, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 8, IDLG = 1, TenGhe = "A", IDPhong = 1, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 9, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 10, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 11, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 12, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 13, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 14, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 15, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 16, IDLG = 1, TenGhe = "B", IDPhong = 1, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 17, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 18, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 19, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 20, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 21, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 22, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 23, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 24, IDLG = 1, TenGhe = "C", IDPhong = 1, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 25, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 26, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 27, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 28, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 29, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 30, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 31, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 32, IDLG = 2, TenGhe = "D", IDPhong = 1, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 33, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 34, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 35, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 36, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 37, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 38, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 39, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 40, IDLG = 2, TenGhe = "E", IDPhong = 1, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 41, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 42, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 43, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 44, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 45, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 46, IDLG = 3, TenGhe = "F", IDPhong = 1, SoGhe = 6, TrangThai = 1 },


                new GheModel { IDGhe = 47, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 48, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 49, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 50, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 51, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 52, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 53, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 54, IDLG = 1, TenGhe = "A", IDPhong = 2, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 55, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 56, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 57, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 58, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 59, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 60, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 61, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 62, IDLG = 1, TenGhe = "B", IDPhong = 2, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 63, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 64, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 65, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 66, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 67, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 68, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 69, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 70, IDLG = 1, TenGhe = "C", IDPhong = 2, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 71, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 72, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 73, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 74, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 75, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 76, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 77, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 78, IDLG = 2, TenGhe = "D", IDPhong = 2, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 79, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 80, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 81, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 82, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 83, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 84, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 85, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 86, IDLG = 2, TenGhe = "E", IDPhong = 2, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 87, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 88, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 89, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 90, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 91, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 92, IDLG = 3, TenGhe = "F", IDPhong = 2, SoGhe = 6, TrangThai = 1 },


                new GheModel { IDGhe = 93, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 94, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 95, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 96, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 97, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 98, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 99, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 100, IDLG = 1, TenGhe = "A", IDPhong = 3, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 101, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 102, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 103, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 104, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 105, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 106, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 107, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 108, IDLG = 1, TenGhe = "B", IDPhong = 3, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 109, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 110, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 111, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 112, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 113, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 114, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 115, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 116, IDLG = 1, TenGhe = "C", IDPhong = 3, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 117, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 118, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 119, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 120, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 121, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 122, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 123, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 124, IDLG = 2, TenGhe = "D", IDPhong = 3, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 125, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 126, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 127, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 128, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 129, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 130, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 131, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 132, IDLG = 2, TenGhe = "E", IDPhong = 3, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 133, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 134, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 135, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 136, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 137, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 138, IDLG = 3, TenGhe = "F", IDPhong = 3, SoGhe = 6, TrangThai = 1 },

                new GheModel { IDGhe = 139, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 140, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 141, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 142, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 143, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 144, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 145, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 146, IDLG = 1, TenGhe = "A", IDPhong = 4, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 147, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 148, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 149, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 150, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 151, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 152, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 153, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 154, IDLG = 1, TenGhe = "B", IDPhong = 4, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 155, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 156, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 157, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 158, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 159, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 160, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 161, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 162, IDLG = 1, TenGhe = "C", IDPhong = 4, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 163, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 164, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 165, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 166, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 167, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 168, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 169, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 170, IDLG = 2, TenGhe = "D", IDPhong = 4, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 171, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 172, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 173, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 174, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 175, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 176, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 177, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 178, IDLG = 2, TenGhe = "E", IDPhong = 4, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 179, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 180, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 181, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 182, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 183, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 184, IDLG = 3, TenGhe = "F", IDPhong = 4, SoGhe = 6, TrangThai = 1 },

                new GheModel { IDGhe = 185, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 186, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 187, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 188, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 189, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 190, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 191, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 192, IDLG = 1, TenGhe = "A", IDPhong = 5, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 193, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 194, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 195, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 196, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 197, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 198, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 199, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 200, IDLG = 1, TenGhe = "B", IDPhong = 5, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 201, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 202, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 203, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 204, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 205, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 206, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 207, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 208, IDLG = 1, TenGhe = "C", IDPhong = 5, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 209, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 210, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 211, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 212, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 213, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 214, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 215, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 216, IDLG = 2, TenGhe = "D", IDPhong = 5, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 217, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 218, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 219, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 220, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 221, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 222, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 6, TrangThai = 1 },
                new GheModel { IDGhe = 223, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 7, TrangThai = 1 },
                new GheModel { IDGhe = 224, IDLG = 2, TenGhe = "E", IDPhong = 5, SoGhe = 8, TrangThai = 1 },

                new GheModel { IDGhe = 225, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 1, TrangThai = 1 },
                new GheModel { IDGhe = 226, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 2, TrangThai = 1 },
                new GheModel { IDGhe = 227, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 3, TrangThai = 1 },
                new GheModel { IDGhe = 228, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 4, TrangThai = 1 },
                new GheModel { IDGhe = 229, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 5, TrangThai = 1 },
                new GheModel { IDGhe = 230, IDLG = 3, TenGhe = "F", IDPhong = 5, SoGhe = 6, TrangThai = 1 }

                );
            modelBuilder.Entity<PhimModel>().HasData(
                new PhimModel { IDPhim = 1, IDPhong = 1, AnhPhim = "1.jpg", TenPhim = "TRÁI TIM QUÁI VẬT", TenDienVien = "Hoàng Thùy Linh, B Trần, Hứa Vĩ Văn, Trịnh Thăng Bình, Hạnh Thúy, Kay Trần", DaoDien = "Tạ Nguyên Hiệp", TheLoai = "Hồi hộp, Tâm Lý", TenNgonNgu = "Tiếng Việt", TenPhuDe = "Tiếng Anh", KhoiChieu = DateTime.Parse("11/20/2020"), ThoiLuong = 89, Rated = 18, TrangThai = 1 },
                new PhimModel { IDPhim = 2, IDPhong = 2, AnhPhim = "1.jpg", TenPhim = "TRỐN CHẠY", TenDienVien = "Sarah Paulson, Kiera Allen", DaoDien = "Aneesh Chaganty", TheLoai = "Hồi hộp, Tâm Lý", TenNgonNgu = "Tiếng Việt", TenPhuDe = "Tiếng Anh", KhoiChieu = DateTime.Parse("11/20/2020"), ThoiLuong = 90, Rated = 16, TrangThai = 1 },
                new PhimModel { IDPhim = 3, IDPhong = 3, AnhPhim = "1.jpg", TenPhim = "THÁP LỬA", TenDienVien = "Sul Kyung-Gu, Son Ye-Jin, Kim Sang-Kyung, Kim In-Kwon, Do Ji-Han, Cha In-Pyo", DaoDien = "Kim Ji-hoon", TheLoai = "Hành Động", TenNgonNgu = "Tiếng Hàn", TenPhuDe = "Tiếng Việt", KhoiChieu = DateTime.Parse("11/20/2020"), ThoiLuong = 121, Rated = 0, TrangThai = 1 },
                new PhimModel { IDPhim = 4, IDPhong = 4, AnhPhim = "1.jpg", TenPhim = "CHỒNG NGƯỜI TA", TenDienVien = "Yaya Trương Nhi, Trịnh Xuân Nhãn, Phạm Thanh Trúc, Tú Hảo", DaoDien = "Nguyễn Hữu Tiến", TheLoai = "Tâm Lý", TenNgonNgu = "Tiếng Việt", TenPhuDe = "Tiếng Anh", KhoiChieu = DateTime.Parse("11/20/2020"), ThoiLuong = 91, Rated = 18, TrangThai = 1 },
                new PhimModel { IDPhim = 5, IDPhong = 5, AnhPhim = "1.jpg", TenPhim = "TIỆC TRĂNG MÁU", TenDienVien = "Thái Hoà, Đức Thịnh, Hồng Ánh, Hứa Vỹ Văn , Thu Trang, Kiều Minh Tuấn, Kaity Nguyễn", DaoDien = "Nguyễn Quang Dũng", TheLoai = "Hài, Tâm Lý", TenNgonNgu = "Tiếng Việt", TenPhuDe = "Tiếng Anh", KhoiChieu = DateTime.Parse("10/23/2020"), ThoiLuong = 118, Rated = 18, TrangThai = 1 }
                ) ;
            modelBuilder.Entity<KhungGioModel>().HasData(
                new KhungGioModel { IDKG = 1, IDPhim = 1, ThoiGian = DateTime.Parse("09:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 2, IDPhim = 1, ThoiGian = DateTime.Parse("10:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 3, IDPhim = 1, ThoiGian = DateTime.Parse("11:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 4, IDPhim = 2, ThoiGian = DateTime.Parse("09:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 5, IDPhim = 3, ThoiGian = DateTime.Parse("09:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 6, IDPhim = 4, ThoiGian = DateTime.Parse("09:30"), TrangThai = 1 },
                new KhungGioModel { IDKG = 7, IDPhim = 5, ThoiGian = DateTime.Parse("09:30"), TrangThai = 1 }
                ) ;
            modelBuilder.Entity<LoaiTKModel>().HasData(
                new LoaiTKModel { IDLTK = 1, TenLTK = "Thành Viên", TrangThai = 1 },
                new LoaiTKModel { IDLTK = 2, TenLTK = "Admin", TrangThai = 1 }
                );
            modelBuilder.Entity<TaiKhoanModel>().HasData(
                new TaiKhoanModel { IDTK = 1, IDLTK=2,Ten="Trọng",Ho="Nguyễn Văn",GioiTinh="Nam",DienThoai="0326440254",NgaySinh=DateTime.Parse("10/23/2000"),Email="vtvantrong272@gmail.com",TaiKhoan="Admin",MatKhau="Admin",AnhDaiDien="1.jpg",DiaChi="Tây Ninh",TrangThai=1}
                );
        }
    }
}
