//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace danhbadienthoai
{
    using System;
    using System.Collections.Generic;
    
    public partial class thongtincanhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thongtincanhan()
        {
            this.khachhangs = new HashSet<khachhang>();
        }
    
        public Nullable<int> ID { get; set; }
        public int Sdt { get; set; }
        public string Hoten { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        public string Xa { get; set; }
        public Nullable<bool> Gioitinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khachhang> khachhangs { get; set; }
    }
}