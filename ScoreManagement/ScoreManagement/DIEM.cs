//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoreManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIEM
    {
        public int ID { get; set; }
        public int MASV { get; set; }
        public int MAMH { get; set; }
        public Nullable<int> CHUYENCAN { get; set; }
        public Nullable<int> BAITAP { get; set; }
        public Nullable<int> GIUAKI { get; set; }
        public Nullable<int> CUOIKI { get; set; }
        public Nullable<int> TONGKET { get; set; }
    
        public virtual MONHOC MONHOC { get; set; }
        public virtual SVIEN SVIEN { get; set; }
    }
}
