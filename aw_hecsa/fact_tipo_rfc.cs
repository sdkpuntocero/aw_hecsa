//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aw_hecsa
{
    using System;
    using System.Collections.Generic;
    
    public partial class fact_tipo_rfc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fact_tipo_rfc()
        {
            this.inf_clientes = new HashSet<inf_clientes>();
            this.inf_proveedores = new HashSet<inf_proveedores>();
        }
    
        public int id_tipo_rfc { get; set; }
        public string desc_tipo_rfc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_clientes> inf_clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_proveedores> inf_proveedores { get; set; }
    }
}
