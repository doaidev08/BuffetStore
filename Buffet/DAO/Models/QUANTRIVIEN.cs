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
    
    public partial class QUANTRIVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUANTRIVIEN()
        {
            this.SANPHAMKHO = new HashSet<SANPHAMKHO>();
        }
    
        public int MaQuanTriVien { get; set; }
        public string TenTruyCapQTV { get; set; }
        public string MatKhau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAMKHO> SANPHAMKHO { get; set; }
    }
}
