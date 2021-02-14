using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadTipoActividad
    {
        private int _idtipo_actividad;
        private string _descripcion;

        public int getIdtipoActividad
        {
            get
            {
                return _idtipo_actividad;
            }
            set
            {
                _idtipo_actividad = value;
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
