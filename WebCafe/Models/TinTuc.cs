//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCafe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinTuc
    {
        public int MaTin { get; set; }
        public string TieuDe { get; set; }
        public Nullable<System.DateTime> NgayViet { get; set; }
        public string NoiDung { get; set; }
        public string Url_friendly { get; set; }
        public Nullable<int> MaDanhMuc { get; set; }
    
        public virtual DanhMuc DanhMuc { get; set; }
    }
}
