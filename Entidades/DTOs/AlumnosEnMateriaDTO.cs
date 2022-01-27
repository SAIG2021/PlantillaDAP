using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DTOs
{
    public class AlumnosEnMateriaDTO
    {
        public int IdVirtual { get; set; }
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public string NombreAlumno { get; set; }
        public string APaternoAlumno { get; set; }
        public string AMaternoAlumno { get; set; }
        public int Edad { get; set; }
        public string ActivoAlumno { get; set; }
        
    }
}
