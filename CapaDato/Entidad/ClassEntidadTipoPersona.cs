using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadTipoPersona
    {

        private int _idpersona;
        private string _descripcion;

        public int getIdPersona
        {
            get
            {
                return _idpersona;
            }
            set
            {
                _idpersona = value;
            }
        }

        public string getDescripcion
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
