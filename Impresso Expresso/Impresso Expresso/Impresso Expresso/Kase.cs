//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impresso_Expresso
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kase
    {
        public Kase()
        {
            this.Racunis = new HashSet<Racuni>();
            this.Transakcijes = new HashSet<Transakcije>();
        }
    
        public int ID { get; set; }
        public decimal StanjeKase { get; set; }
    
        public virtual ICollection<Racuni> Racunis { get; set; }
        public virtual ICollection<Transakcije> Transakcijes { get; set; }
    }
}
