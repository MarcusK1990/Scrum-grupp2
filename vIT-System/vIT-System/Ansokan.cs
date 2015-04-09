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
    
    public partial class Ansokan
    {
        public Ansokan()
        {
            this.Fardmedel = new HashSet<Fardmedel>();
            this.Traktamente = new HashSet<Traktamente>();
            this.Uppehall = new HashSet<Uppehall>();
            this.Utgifter = new HashSet<Utgifter>();
        }
    
        public int AId { get; set; }
        public Nullable<System.DateTime> Avresa { get; set; }
        public Nullable<System.DateTime> Hemresa { get; set; }
        public Nullable<int> TotalSumma { get; set; }
        public Nullable<int> FId { get; set; }
        public Nullable<int> Id { get; set; }
    
        public virtual Forskott Forskott { get; set; }
        public virtual Anstallda Anstallda { get; set; }
        public virtual ICollection<Fardmedel> Fardmedel { get; set; }
        public virtual ICollection<Traktamente> Traktamente { get; set; }
        public virtual ICollection<Uppehall> Uppehall { get; set; }
        public virtual ICollection<Utgifter> Utgifter { get; set; }
    }
}