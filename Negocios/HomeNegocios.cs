using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Common;
using Entidades.DTOs;

namespace Negocios
{
    public class HomeNegocios
    {
        public static List<Cat_Materias>  ObtenerMaterias_Ejemplo()
        {
            var transaccion = new Transaccion();
            var repositorio = new Repositorio<Cat_Materias>(transaccion);
             return  repositorio.ObtenerPorFiltro(x => x.Activo == true).ToList();
        }

        public static List<AlumnosEnMateriaDTO> ObtenerAlumnosIdMateria(int IdMateria)
        {

            TransaccionSQL transaccionSQL = new TransaccionSQL("DBProyectoPlantillaMVCFramework");
            RepositorioSQL repositorioGeneralDBProyectoPlantillaMVCFramework = new RepositorioSQL(transaccionSQL);
            

            string query = "select  Mate.Id ,  Mate.NombreMateria ,  Alum.Nombre,  Alum.APaterno , Alum.AMaterno,  Alum.Edad , Alum.Activo from[DBProyectoPlantillaMVCFramework].[dbo].[tbl_IdMateria_IdAlumno_NN] Paso "
                               + " INNER JOIN[DBProyectoPlantillaMVCFramework].[dbo].[Cat_Materias] Mate "
                                        + " ON Paso.IdMateria = Mate.Id "
                               + " INNER JOIN[DBProyectoPlantillaMVCFramework].[dbo].[tbl_Alumnos] Alum "
                                        + " ON Paso.IdAlumno = Alum.Id "
                           + " where Paso.IdMateria = "+IdMateria+" ";
            transaccionSQL.Conectar();
            DbDataReader leerDatos = repositorioGeneralDBProyectoPlantillaMVCFramework.Ejecutar_Leer(query);
            List<AlumnosEnMateriaDTO> listaAlumnosEnMaterias = new List<AlumnosEnMateriaDTO>();
            int iterador = 0;
            while (leerDatos.Read()) 
            {
                iterador += 1;
                AlumnosEnMateriaDTO nuevoAlumnoEnMateria = new AlumnosEnMateriaDTO();
                nuevoAlumnoEnMateria.IdVirtual = iterador;
                nuevoAlumnoEnMateria.IdMateria =  leerDatos.GetInt32(0);
                nuevoAlumnoEnMateria.Materia = leerDatos[1].ToString().Trim();
                nuevoAlumnoEnMateria.NombreAlumno = leerDatos[2].ToString().Trim();
                nuevoAlumnoEnMateria.APaternoAlumno = leerDatos[3].ToString().Trim();
                nuevoAlumnoEnMateria.AMaternoAlumno = leerDatos[4].ToString().Trim();
                nuevoAlumnoEnMateria.Edad = leerDatos.GetInt32(5);
                nuevoAlumnoEnMateria.ActivoAlumno = leerDatos.GetBoolean(6) == false ? "" : "TRUE" ;
                listaAlumnosEnMaterias.Add(nuevoAlumnoEnMateria);
            }

            transaccionSQL.Desconectar();
            return listaAlumnosEnMaterias;
        }




        public static List<EspecialidadDTO> ObtenerEspecialidad(int IdMateria)
        {
            List<EspecialidadDTO> EspecialidadEncontrada = new List<EspecialidadDTO>();

            TransaccionSQL transaccionSQL = new TransaccionSQL("DBProyectoPlantillaMVCFramework");
            RepositorioSQL repositorioGeneralDBProyectoPlantillaMVCFramework = new RepositorioSQL(transaccionSQL);


            string query = "SELECT IdEspecialidad  FROM [DBProyectoPlantillaMVCFramework].[dbo].[Cat_Materias] where Id = "+IdMateria+" ";
            transaccionSQL.Conectar();
            DbDataReader leerDatos;

            leerDatos = repositorioGeneralDBProyectoPlantillaMVCFramework.Ejecutar_Leer(query);
            int IdEspecialidad = 0;
            while (leerDatos.Read())
            {
               IdEspecialidad = leerDatos.GetInt32(0);
            }
            transaccionSQL.Desconectar();


            if (IdEspecialidad > 0) 
            {
                string queryEspecialidad = "SELECT *   FROM [DBProyectoPlantillaMVCFramework].[dbo].[tbl_Especialidades] where Id = "+IdMateria+" ";
                transaccionSQL.Conectar();

                leerDatos = null;
                leerDatos = repositorioGeneralDBProyectoPlantillaMVCFramework.Ejecutar_Leer(queryEspecialidad);

                int Iterador = 1;
                while (leerDatos.Read())
                {
                    EspecialidadDTO nuevaEspecialidadEncontrada = new EspecialidadDTO();
                    nuevaEspecialidadEncontrada.IdVirtual = Iterador++;
                    nuevaEspecialidadEncontrada.Id = leerDatos.GetInt32(0) ;
                    nuevaEspecialidadEncontrada.Especialidad = leerDatos.GetString(1); ;
                    nuevaEspecialidadEncontrada.Titulo = leerDatos.GetBoolean(2) ? "TRUE" : "FALSE"  ;
                    nuevaEspecialidadEncontrada.Tecnico = leerDatos.GetBoolean(3) ? "TRUE" : "FALSE";
                    nuevaEspecialidadEncontrada.AniosActivo = leerDatos.GetInt32(4);
                    nuevaEspecialidadEncontrada.Activo = leerDatos.GetBoolean(5) ? "TRUE" : "FALSE"; ;

                    EspecialidadEncontrada.Add(nuevaEspecialidadEncontrada);
                }
                transaccionSQL.Desconectar();

            }

            return EspecialidadEncontrada;
        }


    }
}
