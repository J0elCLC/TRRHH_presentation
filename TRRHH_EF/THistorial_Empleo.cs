//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRRHH_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class THistorial_Empleo
    {
        public int codigo_area { get; set; }
        public System.DateTime fecha_de_inicio { get; set; }
        public System.DateTime fecha_de_contratacion { get; set; }
    
        public virtual TArea TArea { get; set; }
        public virtual TEmpleado TEmpleado { get; set; }
        public virtual TEmpleo TEmpleo { get; set; }
    }
}
