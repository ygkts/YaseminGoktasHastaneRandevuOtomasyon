//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneRandevuTakipOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktor()
        {
            this.Randevus = new HashSet<Randevu>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DTarih { get; set; }
        public string DYer { get; set; }
        public string Cinsiyet { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> BolumID { get; set; }
        public string BolumAd { get; set; }
        public byte[] Resim { get; set; }
    
        public virtual Bolum Bolum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevus { get; set; }
    }
}
