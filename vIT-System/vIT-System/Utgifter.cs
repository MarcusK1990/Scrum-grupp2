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
    using System;
    using System.Collections.Generic;
    
    public partial class Utgifter
    {
        public int UtId { get; set; }
        public string Typ { get; set; }
        public string Valuta { get; set; }
        public int ValutaKurs { get; set; }
        public string Kvitto { get; set; }
        public int UtSumma { get; set; }
        public int Moms { get; set; }
        public Nullable<int> AId { get; set; }
    
        public virtual Ansokan Ansokan { get; set; }
    }
}
