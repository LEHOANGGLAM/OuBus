//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OUBus
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuyenDi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenDi()
        {
            this.VeXes = new HashSet<VeXe>();
        }

        public static explicit operator ChuyenDi(List<TimKiemCD_Result> v)
        {
            throw new NotImplementedException();
        }

        public int MaChuyenDi { get; set; }
        public Nullable<int> MaXe { get; set; }
        public Nullable<System.DateTime> NgayKhoiHanh { get; set; }
        public Nullable<System.TimeSpan> ThoiGianKhoiHanh { get; set; }
        public string DiemKhoiHanh { get; set; }
        public string DiemKetThuc { get; set; }
        public Nullable<int> SoGheTrong { get; set; }
        public Nullable<int> SoGheDat { get; set; }
        public Nullable<int> GiaVe { get; set; }
    
        public virtual BaoCaoDoanhThuChuyenDi BaoCaoDoanhThuChuyenDi { get; set; }
        public virtual XeKhach XeKhach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXes { get; set; }
    }
}
