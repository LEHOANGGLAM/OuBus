//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OUBus
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core.Objects.DataClasses;
    using System.Linq;
    
    public partial class OuBusEntities1 : DbContext
    {
        public OuBusEntities1()
            : base("name=OuBusEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BaoCaoDoanhThuChuyenDi> BaoCaoDoanhThuChuyenDis { get; set; }
        public DbSet<ChuyenDi> ChuyenDis { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanLoaiNhanVien> PhanLoaiNhanViens { get; set; }
        public DbSet<PhanQuyen> PhanQuyens { get; set; }
        public DbSet<TaiKhoanDangNhap> TaiKhoanDangNhaps { get; set; }
        public DbSet<VeXe> VeXes { get; set; }
        public DbSet<XeKhach> XeKhaches { get; set; }
    
        public virtual ObjectResult<pr_TKDT_Result> pr_TKDT(Nullable<System.DateTime> ngay1, Nullable<System.DateTime> ngay2)
        {
            var ngay1Parameter = ngay1.HasValue ?
                new ObjectParameter("Ngay1", ngay1) :
                new ObjectParameter("Ngay1", typeof(System.DateTime));
    
            var ngay2Parameter = ngay2.HasValue ?
                new ObjectParameter("Ngay2", ngay2) :
                new ObjectParameter("Ngay2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_TKDT_Result>("pr_TKDT", ngay1Parameter, ngay2Parameter);
        }
    
        public virtual int SuaThongTinChuyenDi(Nullable<int> machuyendi, Nullable<int> maxe, Nullable<System.DateTime> ngay, Nullable<System.TimeSpan> thoigian, string khoihanh, string ketthuc, string giave)
        {
            var machuyendiParameter = machuyendi.HasValue ?
                new ObjectParameter("machuyendi", machuyendi) :
                new ObjectParameter("machuyendi", typeof(int));
    
            var maxeParameter = maxe.HasValue ?
                new ObjectParameter("maxe", maxe) :
                new ObjectParameter("maxe", typeof(int));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            var thoigianParameter = thoigian.HasValue ?
                new ObjectParameter("thoigian", thoigian) :
                new ObjectParameter("thoigian", typeof(System.TimeSpan));
    
            var khoihanhParameter = khoihanh != null ?
                new ObjectParameter("khoihanh", khoihanh) :
                new ObjectParameter("khoihanh", typeof(string));
    
            var ketthucParameter = ketthuc != null ?
                new ObjectParameter("ketthuc", ketthuc) :
                new ObjectParameter("ketthuc", typeof(string));
    
            var giaveParameter = giave != null ?
                new ObjectParameter("giave", giave) :
                new ObjectParameter("giave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaThongTinChuyenDi", machuyendiParameter, maxeParameter, ngayParameter, thoigianParameter, khoihanhParameter, ketthucParameter, giaveParameter);
        }
    
        public virtual int SuaThongTinNV(Nullable<int> manv, Nullable<int> maloai, string ten, Nullable<System.DateTime> ngaysinh, string quequan, Nullable<int> cmnd)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var quequanParameter = quequan != null ?
                new ObjectParameter("quequan", quequan) :
                new ObjectParameter("quequan", typeof(string));
    
            var cmndParameter = cmnd.HasValue ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaThongTinNV", manvParameter, maloaiParameter, tenParameter, ngaysinhParameter, quequanParameter, cmndParameter);
        }
    
        public virtual int SuaThongTinVeXe(Nullable<int> mave, Nullable<int> manhanvien, Nullable<int> machuyendi, string ten, Nullable<int> sdt, string vitri)
        {
            var maveParameter = mave.HasValue ?
                new ObjectParameter("mave", mave) :
                new ObjectParameter("mave", typeof(int));
    
            var manhanvienParameter = manhanvien.HasValue ?
                new ObjectParameter("manhanvien", manhanvien) :
                new ObjectParameter("manhanvien", typeof(int));
    
            var machuyendiParameter = machuyendi.HasValue ?
                new ObjectParameter("machuyendi", machuyendi) :
                new ObjectParameter("machuyendi", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            var vitriParameter = vitri != null ?
                new ObjectParameter("vitri", vitri) :
                new ObjectParameter("vitri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaThongTinVeXe", maveParameter, manhanvienParameter, machuyendiParameter, tenParameter, sdtParameter, vitriParameter);
        }
    
        public virtual int ThemChuyenDi(Nullable<int> machuyendi, Nullable<int> maxe, Nullable<System.DateTime> ngay, Nullable<System.TimeSpan> thoigian, string khoihanh, string ketthuc, string giave)
        {
            var machuyendiParameter = machuyendi.HasValue ?
                new ObjectParameter("machuyendi", machuyendi) :
                new ObjectParameter("machuyendi", typeof(int));
    
            var maxeParameter = maxe.HasValue ?
                new ObjectParameter("maxe", maxe) :
                new ObjectParameter("maxe", typeof(int));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            var thoigianParameter = thoigian.HasValue ?
                new ObjectParameter("thoigian", thoigian) :
                new ObjectParameter("thoigian", typeof(System.TimeSpan));
    
            var khoihanhParameter = khoihanh != null ?
                new ObjectParameter("khoihanh", khoihanh) :
                new ObjectParameter("khoihanh", typeof(string));
    
            var ketthucParameter = ketthuc != null ?
                new ObjectParameter("ketthuc", ketthuc) :
                new ObjectParameter("ketthuc", typeof(string));
    
            var giaveParameter = giave != null ?
                new ObjectParameter("giave", giave) :
                new ObjectParameter("giave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemChuyenDi", machuyendiParameter, maxeParameter, ngayParameter, thoigianParameter, khoihanhParameter, ketthucParameter, giaveParameter);
        }
    
        public virtual int ThemTaiKhoan(string taikhoan, string matkhau, Nullable<int> manv, Nullable<int> maquyen, string ten, string email, Nullable<System.DateTime> ngaysinh)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var maquyenParameter = maquyen.HasValue ?
                new ObjectParameter("maquyen", maquyen) :
                new ObjectParameter("maquyen", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemTaiKhoan", taikhoanParameter, matkhauParameter, manvParameter, maquyenParameter, tenParameter, emailParameter, ngaysinhParameter);
        }
    
        public virtual int ThemThongTinNV(Nullable<int> maloai, string ten, Nullable<System.DateTime> ngaysinh, string quequan, Nullable<int> cmnd)
        {
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var quequanParameter = quequan != null ?
                new ObjectParameter("quequan", quequan) :
                new ObjectParameter("quequan", typeof(string));
    
            var cmndParameter = cmnd.HasValue ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemThongTinNV", maloaiParameter, tenParameter, ngaysinhParameter, quequanParameter, cmndParameter);
        }
    
        public virtual int ThemVeXe(Nullable<int> machuyendi, Nullable<int> manhanvien, string ten, string sdt, string vitri)
        {
            var machuyendiParameter = machuyendi.HasValue ?
                new ObjectParameter("machuyendi", machuyendi) :
                new ObjectParameter("machuyendi", typeof(int));
    
            var manhanvienParameter = manhanvien.HasValue ?
                new ObjectParameter("manhanvien", manhanvien) :
                new ObjectParameter("manhanvien", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var vitriParameter = vitri != null ?
                new ObjectParameter("vitri", vitri) :
                new ObjectParameter("vitri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemVeXe", machuyendiParameter, manhanvienParameter, tenParameter, sdtParameter, vitriParameter);
        }
    
        public virtual ObjectResult<TimKiemCD_Result> TimKiemCD(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemCD_Result>("TimKiemCD", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemNVtheoMaLoaiNV_Result> TimKiemNVtheoMaLoaiNV(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemNVtheoMaLoaiNV_Result>("TimKiemNVtheoMaLoaiNV", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemNVtheoMaNV_Result> TimKiemNVtheoMaNV(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemNVtheoMaNV_Result>("TimKiemNVtheoMaNV", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemNVtheoTenNV_Result> TimKiemNVtheoTenNV(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemNVtheoTenNV_Result>("TimKiemNVtheoTenNV", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemVeXetheoMaCD_Result> TimKiemVeXetheoMaCD(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemVeXetheoMaCD_Result>("TimKiemVeXetheoMaCD", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemVeXetheoSDT_Result> TimKiemVeXetheoSDT(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemVeXetheoSDT_Result>("TimKiemVeXetheoSDT", nhapParameter);
        }
    
        public virtual ObjectResult<TimKiemVeXetheoTenKH_Result> TimKiemVeXetheoTenKH(string nhap)
        {
            var nhapParameter = nhap != null ?
                new ObjectParameter("nhap", nhap) :
                new ObjectParameter("nhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemVeXetheoTenKH_Result>("TimKiemVeXetheoTenKH", nhapParameter);
        }
    
        public virtual int XoaChuyenDi(Nullable<int> maChuyenDi)
        {
            var maChuyenDiParameter = maChuyenDi.HasValue ?
                new ObjectParameter("MaChuyenDi", maChuyenDi) :
                new ObjectParameter("MaChuyenDi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaChuyenDi", maChuyenDiParameter);
        }
    
        public virtual int XoaTaiKhoan(Nullable<int> manhanvien)
        {
            var manhanvienParameter = manhanvien.HasValue ?
                new ObjectParameter("manhanvien", manhanvien) :
                new ObjectParameter("manhanvien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaTaiKhoan", manhanvienParameter);
        }
    
        public virtual int XoaThongTinNV(Nullable<int> manv)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaThongTinNV", manvParameter);
        }
    
        public virtual int XoaVeXe(Nullable<int> mave)
        {
            var maveParameter = mave.HasValue ?
                new ObjectParameter("mave", mave) :
                new ObjectParameter("mave", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaVeXe", maveParameter);
        }
    }
}
