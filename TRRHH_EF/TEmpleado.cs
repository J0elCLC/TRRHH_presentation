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
    
    public partial class TEmpleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEmpleado()
        {
            this.THistorial_Empleo = new HashSet<THistorial_Empleo>();
        }
    
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string DNI { get; set; }
        public string apellido_paterno { get; set; }
        public System.DateTime fecha_de_nacimiento { get; set; }
        public System.DateTime fecha_de_contratacion { get; set; }
        public decimal salario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THistorial_Empleo> THistorial_Empleo { get; set; }
    }
}