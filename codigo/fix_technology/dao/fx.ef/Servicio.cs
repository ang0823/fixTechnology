//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fix_technology.dao.fx.ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicio
    {
        public string numero_servicio { get; set; }
        public System.DateTime fecha_recibo { get; set; }
        public Nullable<System.DateTime> garantia { get; set; }
        public Nullable<double> anticipo { get; set; }
        public double total { get; set; }
        public int id_tecnico { get; set; }
        public string id_equipo { get; set; }
    
        public virtual Equipo Equipo { get; set; }
        public virtual Tecnico Tecnico { get; set; }
    }
}
