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
    
    public partial class inf_sepomex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inf_sepomex()
        {
            this.inf_clientes = new HashSet<inf_clientes>();
            this.inf_empresa = new HashSet<inf_empresa>();
            this.inf_proveedores = new HashSet<inf_proveedores>();
        }
    
        public int id_codigo { get; set; }
        public string d_codigo { get; set; }
        public string d_asenta { get; set; }
        public string d_tipo_asenta { get; set; }
        public string d_mnpio { get; set; }
        public string d_estado { get; set; }
        public string d_ciudad { get; set; }
        public string d_cp { get; set; }
        public string c_estado { get; set; }
        public string c_oficina { get; set; }
        public string c_cp { get; set; }
        public string c_tipo_asenta { get; set; }
        public string c_mnpio { get; set; }
        public Nullable<int> id_asenta_cpcons { get; set; }
        public string d_zona { get; set; }
        public string c_cve_ciudad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_clientes> inf_clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_empresa> inf_empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_proveedores> inf_proveedores { get; set; }
    }
}
