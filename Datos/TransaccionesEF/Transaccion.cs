﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Transaccion : IDisposable
    {
        private DBProyectoPlantillaMVCFrameworkEntities _contexto;
        public Transaccion()
        {
            _contexto = new DBProyectoPlantillaMVCFrameworkEntities();
        }
        internal DBProyectoPlantillaMVCFrameworkEntities Contexto
        {
            get
            {
                return _contexto;
            }
        }
        public void GuardarCambios()
        {
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }






        /******************************************************************************************************************************************/
        /**************************************************  Metodos Asincronicos       **********************************************************/
        //public Transaccion()
        //{
        //    _contexto = new FoliacionInterfacesCargadasEntities();
        //}

        public async Task GuardarCambiosAsincronicos()
        {
            await _contexto.SaveChangesAsync();
        }



    }
}
