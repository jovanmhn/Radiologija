//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Radiologija
{
    using System;
    using System.Collections.Generic;
    
    public partial class doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktor()
        {
            this.nalaz = new HashSet<nalaz>();
        }
    
        public int id_doktor { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string titula { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nalaz> nalaz { get; set; }
    }
}