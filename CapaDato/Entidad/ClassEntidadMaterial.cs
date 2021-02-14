using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadMaterial
    {
        private int _idmaterial;
        private string _descripcion;
        private string _especificaciones;
        private int _idmarca;
        private int _idtipo_material;

        public int getidmaterial
        {
            get
            {
                return _idmaterial;
            }
            set { _idmaterial = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string getespecificaciones
        {
            get { return _especificaciones; }
            set { _especificaciones = value; }
        }

        public int getidmarca
        {
            get { return _idmarca; }
            set { _idmarca = value; }
        }

        public int getidtipomaterial
        {
            get { return _idtipo_material; }
            set { _idtipo_material = value; }
        }
    }
}
