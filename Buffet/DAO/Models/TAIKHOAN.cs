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
    
    public partial class TAIKHOAN
    {
        public int MaTaiKhoan { get; set; }
        public string TenTruyCap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public int MaPhanQuyen { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
