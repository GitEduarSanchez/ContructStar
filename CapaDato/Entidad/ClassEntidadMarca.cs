using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadMarca
    {
        private int _idmarca;
        private string _descripcion;

        public int getidmarca
        {
            get { return _idmarca; }
            set { _idmarca = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
