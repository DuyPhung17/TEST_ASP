//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HSBA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HSBA()
        {
            this.BANKECHIPHIs = new HashSet<BANKECHIPHI>();
            this.BANKEDICHVUs = new HashSet<BANKEDICHVU>();
            this.CT_HSBA = new HashSet<CT_HSBA>();
            this.TOATHUOCs = new HashSet<TOATHUOC>();
        }
    
        public int MAHSBA { get; set; }
        public int MABN { get; set; }
        public int MABENH { get; set; }
        public System.DateTime NGAYNHAPVIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANKECHIPHI> BANKECHIPHIs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANKEDICHVU> BANKEDICHVUs { get; set; }
        public virtual BENH BENH { get; set; }
        public virtual BENHNHAN BENHNHAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HSBA> CT_HSBA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOATHUOC> TOATHUOCs { get; set; }
    }
}
