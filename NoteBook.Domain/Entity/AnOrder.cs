//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoteBook.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AnOrder
    {
        public int id { get; set; }
        public string customer_name { get; set; }
        public string description { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> state_id { get; set; }
    
        //[ForeignKey("State")]
        //public virtual State State { get; set; }
    }
}
