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
    
    public partial class StavkeNarudzbe
    {
        public int NarudzbaID { get; set; }
        public int ArtiklID { get; set; }
        public double Kolicina { get; set; }
    
        public virtual Artikli Artikli { get; set; }
        public virtual Narudzbe Narudzbe { get; set; }
    }
}