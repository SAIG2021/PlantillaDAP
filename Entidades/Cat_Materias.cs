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
    
    public partial class Cat_Materias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_Materias()
        {
            this.tbl_IdMateria_IdAlumno_NN = new HashSet<tbl_IdMateria_IdAlumno_NN>();
        }
    
        public int Id { get; set; }
        public string NombreMateria { get; set; }
        public string Abreviatura { get; set; }
        public bool EstaCertificada { get; set; }
        public Nullable<int> IdEspecialidad { get; set; }
        public bool Activo { get; set; }
    
        public virtual tbl_Especialidades tbl_Especialidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_IdMateria_IdAlumno_NN> tbl_IdMateria_IdAlumno_NN { get; set; }
    }
}
