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
    
    public partial class DOUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOUONG()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public int MaDoUong { get; set; }
        public string TenDoUong { get; set; }
        public decimal GiaDoUong { get; set; }
        public int SoLuongDoUong { get; set; }
        public bool TinhTrangDoUong { get; set; }
        public Nullable<int> MaDanhMucDoUong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DANHMUCDOUONG DANHMUCDOUONG { get; set; }
    }
}
