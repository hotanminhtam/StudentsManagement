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
    
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            this.DIEMs = new HashSet<DIEM>();
        }
    
        public int ID { get; set; }
        public int MAMH { get; set; }
        public string TENMH { get; set; }
        public Nullable<int> TINCHI { get; set; }
        public Nullable<System.TimeSpan> GIOHOC { get; set; }
        public Nullable<int> MAKHOA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
        public virtual KHOA KHOA { get; set; }
    }
}
