//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vIT_System
{
    using System.Collections.Generic;
    
    public partial class Anstallda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anstallda()
        {
            this.Ansokan = new HashSet<Ansokan>();
            this.Forskott = new HashSet<Forskott>();
        }
    
        public int Id { get; set; }
        public string Losenord { get; set; }
        public string Fnamn { get; set; }
        public string Enamn { get; set; }
        public int PersNr { get; set; }
        public string Mail { get; set; }
        public string Chef { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ansokan> Ansokan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forskott> Forskott { get; set; }
    }
}
