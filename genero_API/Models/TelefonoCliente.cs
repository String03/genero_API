//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace genero_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TelefonoCliente
    {
        public int id { get; set; }
        public Nullable<int> cliente_fk { get; set; }
        public Nullable<int> telefono_fk { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Telefono Telefono { get; set; }
    }
}
