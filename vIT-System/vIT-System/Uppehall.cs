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

    public partial class Uppehall
    {
        public int UppId { get; set; }
        public Nullable<int> Dagar { get; set; }
        public string Kommentar { get; set; }
        public Nullable<int> AId { get; set; }
    
        public virtual Ansokan Ansokan { get; set; }
    }
}
