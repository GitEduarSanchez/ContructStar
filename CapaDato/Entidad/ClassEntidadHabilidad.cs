using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadHabilidad
    {
        private int _idhabilidad;
        private string _descripcion;

        public int getidhabilidad
        {
            get { return _idhabilidad; }
            set { _idhabilidad = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
