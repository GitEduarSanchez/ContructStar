using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadPais
    {

        private int _idpais;
        private string _descripcion;

        public int getidpais
        {
            get
            {
                return _idpais;
            }
            set
            {
                _idpais = value;
            }
        }

        public string getdescripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
    }
}
