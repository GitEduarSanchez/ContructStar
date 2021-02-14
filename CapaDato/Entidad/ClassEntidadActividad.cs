using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadActividad
    {
        private int _idactividad;
        private string _descripcion;
        private int _idtipo_actividad;

        public int getidactividad
        {
            get { return _idactividad; }
            set { _idactividad = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int getidtipoactividad
        {
            get { return _idtipo_actividad; }
            set { _idtipo_actividad = value; }
        }

    }
}
