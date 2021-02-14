using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadUnd
    {
        private int _idund;
        private string _descripcion;


        public int getIdund
        {
            get
            {
                return _idund;
            }
            set
            {
                _idund = value;
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
