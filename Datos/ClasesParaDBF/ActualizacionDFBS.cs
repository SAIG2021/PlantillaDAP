
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.ClasesParaDBF
{

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////     ACTUALIZA UN REGISTRO EN UN DBF       //////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public class ActualizacionDFBS
    {
       

        /// <summary>
        /// Metodo para actualizar una tabla en especifico pasando la ruta y el nombre del archivo, 
        /// </summary>
        /// <param name="RutaPath"></param>
        /// <param name="NombreArchivo"></param>
        /// <returns></returns>
        //public static string ActualizarDBF_Sagitari_A_N(string RutaPath, string NombreArchivo, List<ResumenPersonalAFoliarDTO> ResumenPersonalFoliar)
        // {
        //    //EjemploDePath:  string pathPruebaSERVER208 = @"F:\SAGITARI\GENERAL\ARCHIVOS\";


        //    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+RutaPath+";Extended Properties=dBASE 5.0;";

        //    int ElementosModificados = 0;

        //    try
        //    {
        //        using (OleDbConnection con = new OleDbConnection(constr))
        //        {
        //            con.Open();

        //            foreach (ResumenPersonalAFoliarDTO nuevoRegistro in ResumenPersonalFoliar)
        //            {
        //                string ExecutarQuery = "UPDATE ["+NombreArchivo+"] SET Num_che = '"+nuevoRegistro.NumChe+"', Banco_x = '"+nuevoRegistro.BancoX+"', Cuenta_x = '"+nuevoRegistro.CuentaX+"' , Observa = '"+nuevoRegistro.Observa+"' WHERE NUM = '"+nuevoRegistro.CadenaNumEmpleado+"' and RFC = '"+nuevoRegistro.RFC+"' and LIQUIDO = "+nuevoRegistro.Liquido+" and DELEG = '"+nuevoRegistro.Delegacion+"' ";
                    
        //                OleDbCommand cmd = new OleDbCommand(ExecutarQuery, con);

        //                int modificado = cmd.ExecuteNonQuery();

        //                if (modificado > 0)
        //                {
        //                    ElementosModificados += modificado;
        //                }


        //            }
        //            con.Close();
        //        }
        //    }
        //    catch (System.Data.OleDb.OleDbException E)
        //    {
        //        return E.Message.ToString();

        //        Debug.WriteLine("Ocurrio un error :" + E.Message.ToString());
        //    }
        //    return Convert.ToString(ElementosModificados);
        //}



        //public static async Task<string> ActualizarDBF_Sagitari_A_N_(string RutaPath, string NombreArchivo, List<ResumenPersonalAFoliarDTO> ResumenPersonalFoliar, bool EsPena)
        //{
        //    //EjemploDePath:  string pathPruebaSERVER208 = @"F:\SAGITARI\GENERAL\ARCHIVOS\";


        //    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+RutaPath+";Extended Properties=dBASE 5.0;";
        //    List<Task> tareas = new List<Task>();
        //    int ElementosModificados = 0;

        //    int totalActualizado = 0;
        //    try
        //    {
        //        using (OleDbConnection con = new OleDbConnection(constr))
        //        {



        //            await con.OpenAsync(); 
        //            foreach (ResumenPersonalAFoliarDTO nuevoRegistro in ResumenPersonalFoliar)
        //            {
        //                string ExecutarQuery = "";
        //                if (EsPena)
        //                {
        //                    ExecutarQuery = "UPDATE ["+NombreArchivo+"] SET Num_che = '" + nuevoRegistro.NumChe + "', Banco_x = '" + nuevoRegistro.BancoX + "', Cuenta_x = '" + nuevoRegistro.CuentaX + "' , Observa = '" + nuevoRegistro.Observa + "' WHERE NUM = '" + nuevoRegistro.CadenaNumEmpleado + "' and RFC = '" + nuevoRegistro.RFC + "' and LIQUIDO = " + nuevoRegistro.Liquido + " and DELEG = '" + nuevoRegistro.Delegacion + "' and Benef = '" + nuevoRegistro.NumBeneficiario + "' ";

        //                }
        //                else
        //                {
        //                    ExecutarQuery = "UPDATE ["+NombreArchivo+"] SET Num_che = '" + nuevoRegistro.NumChe + "', Banco_x = '" + nuevoRegistro.BancoX + "', Cuenta_x = '" + nuevoRegistro.CuentaX + "' , Observa = '" + nuevoRegistro.Observa + "' WHERE NUM = '" + nuevoRegistro.CadenaNumEmpleado + "' and RFC = '" + nuevoRegistro.RFC + "' and LIQUIDO = " + nuevoRegistro.Liquido + " and DELEG = '" + nuevoRegistro.Delegacion + "' ";

        //                }


        //                tareas.Add(new OleDbCommand(ExecutarQuery, con).ExecuteNonQueryAsync());

        //            }




        //            await Task.WhenAll(tareas);

        //            con.Close();

                  
        //            return Convert.ToString(tareas.Count());
        //        }
        //    }
        //    catch (System.Data.OleDb.OleDbException E)
        //    {
        //       return E.Message.ToString();

        //        //Debug.WriteLine("Ocurrio un error :" + E.Message.ToString());
        //    }
        //   return Convert.ToString(ElementosModificados);
        //}


       

    }
}
