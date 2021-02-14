using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadCiudad
    {

        private int _idciudad;
        private string _descripcion;
        private int _iddepartamento;

        public int getidciudad
        {
            get { return _idciudad; }
            set { _idciudad = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int getiddepartamento
        {
            get { return _iddepartamento; }
            set { _iddepartamento = value; }
        }

    }

}
