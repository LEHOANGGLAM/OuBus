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
    
    public partial class VeXe
    {
        public int MaVe { get; set; }
        public Nullable<int> MaChuyenDi { get; set; }
        public string TenKhachHang { get; set; }
        public Nullable<int> SoDienThoai { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public string VitriGhe { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual ChuyenDi ChuyenDi { get; set; }
    }
}
