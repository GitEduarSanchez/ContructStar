using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadAnexo
    {

        private int _idanexos;
        private string _descripcion;
        private int _idciudad;


        public int getidanexos
        {
            get { return _idanexos; }
            set { _idanexos = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int getidciudad
        {
            get { return _idciudad; }
            set { _idciudad = value; }
        }

    }
}
