//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _190413_ProjeV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makaleler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makaleler()
        {
            this.MakaleResimleri = new HashSet<MakaleResimleri>();
            this.Yorumlar = new HashSet<Yorumlar>();
            this.Etiketler = new HashSet<Etiketler>();
        }
    
        public int MakalelerID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> UyeID { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<int> GoruntulenmeSayisi { get; set; }
        public Nullable<int> Begenme { get; set; }
        public Nullable<int> Begenmeme { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Uyeler Uyeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleResimleri> MakaleResimleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiketler> Etiketler { get; set; }
    }
}
