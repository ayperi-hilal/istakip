//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace personelisTakip.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_cagrilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_cagrilar()
        {
            this.tblCagriDetay = new HashSet<tblCagriDetay>();
        }
    
        public int id { get; set; }
        public Nullable<int> cagriFirma { get; set; }
        public string konu { get; set; }
        public string aciklama { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<int> cagriPersonel { get; set; }
    
        public virtual tblFirmalar tblFirmalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCagriDetay> tblCagriDetay { get; set; }
        public virtual tbl_personeller tbl_personeller { get; set; }
    }
}