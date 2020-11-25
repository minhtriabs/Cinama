using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Areas.Admin.Models;
using Cinema.Areas.Admin.Helper;

namespace Cinema.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        {
            
        }
        public DbSet<ThanhPhoModel> ThanhPho { get; set; }
        public DbSet<RapModel> Rap { get; set; }
        public DbSet<PhongModel> Phong { get; set; }
        public DbSet<PhimModel> Phim { get; set; }
        public DbSet<GheModel> Ghe { get; set; }
        public DbSet<LoaiGheModel> LoaiGhe { get; set; }
        public DbSet<KhungGioModel> KhungGio { get; set; }
        public DbSet<LoaiTKModel> LoaiTK { get; set; }
        public DbSet<TaiKhoanModel> TaiKhoan { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
        public DbSet<ChiTietHoaDonModel> ChiTietHoaDon { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
