//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Especialidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Especialidades()
        {
            this.Cat_Materias = new HashSet<Cat_Materias>();
        }
    
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public bool Titulo { get; set; }
        public bool Tecnico { get; set; }
        public bool Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_Materias> Cat_Materias { get; set; }
    }
}