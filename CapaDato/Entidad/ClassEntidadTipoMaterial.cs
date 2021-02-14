using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadTipoMaterial
    {
        private int _idtipo_material;
        private string _descripcion;

        public int getIdTipoMaterial
        {
            get
            {
                return _idtipo_material;
            }
            set
            {
                _idtipo_material = value;
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
