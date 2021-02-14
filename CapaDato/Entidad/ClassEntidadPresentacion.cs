using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadPresentacion
    {

        private int _idpresentacion;
        private string _descripcion;

        public int getidpresentacion
        {
            get { return _idpresentacion; }
            set { _idpresentacion = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
