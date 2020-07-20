﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            this.CT_TOATHUOC = new HashSet<CT_TOATHUOC>();
        }
    
        public int MATHUOC { get; set; }
        [DisplayName ("Tên Thuốc")]
        public string TENTHUOC { get; set; }
        [DisplayName("Xuất Xứ")]
        public string XUATXU { get; set; }
        [DisplayName("Ngày Sản Xuất")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime NSX { get; set; }
        [DisplayName("Hạn Sử Dụng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime HSD { get; set; }
        [DisplayName("Đơn Vị Tính")]
        public string DONVITINH { get; set; }
        [DisplayName("Đơn Giá")]
        public int DONGIATHUOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TOATHUOC> CT_TOATHUOC { get; set; }
    }
}
