//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LivingComplex.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offers
    {
        public int idOffer { get; set; }
        public int OfferSenderFlatID { get; set; }
        public int Service { get; set; }
        public string ShortDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Flats Flats { get; set; }
        public virtual Service Service1 { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
