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
    using System.Collections.Generic;
    
    public partial class BaoCaoDoanhThuChuyenDi
    {
        public int MaChuyenDi { get; set; }
        public Nullable<int> DoanhThu { get; set; }
        public Nullable<int> SoVe { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
    
        public virtual ChuyenDi ChuyenDi { get; set; }
    }
}
