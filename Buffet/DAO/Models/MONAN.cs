//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buffet.DAO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MONAN
    {
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string LoaiMonAn { get; set; }
        public int SoLuongMonAn { get; set; }
        public bool TinhTrangMonAn { get; set; }
        public Nullable<int> MaDanhMucMonAn { get; set; }
    
        public virtual DANHMUCMONAN DANHMUCMONAN { get; set; }
    }
}
