using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadMaestroAlcance
    {

        private int _idmaestro_alcance;
        private int _idmaestro;
        private int _idciudad;


        public int getidmaestroalcance
        {
            get { return _idmaestro_alcance; }
            set { _idmaestro_alcance = value; }
        }

        public int getidmaestro
        {
            get { return _idmaestro; }
            set { _idmaestro = value; }
        }

        public int getidciudad
        {
            get
            {
                return _idciudad;
            }
            set { _idciudad = value; }
        }

    }
}
