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

    public partial class CT_HSBA
    {
        public int MAHSBA { get; set; }
        public int MABS { get; set; }
        [DisplayName ("Ngày Khám")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime NGAYKHAM { get; set; }
        [DisplayName("Tình Trạng")]
        public string TINHTRANG { get; set; }
    
        public virtual BACSI BACSI { get; set; }
        public virtual HSBA HSBA { get; set; }
    }
}
