//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hairdresser_Salon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uzytkownicy
    {
        public int IDPackage { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }
        public string Plec { get; set; }
        public Nullable<int> IDRezerwacji { get; set; }
    
        public virtual Rezerwacje Rezerwacje { get; set; }
    }
}
