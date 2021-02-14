using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadMaestroHabilidad
    {
        private int _idmaestro_habilidad;
        private int _idmaestro;
        private int _idhabilidad;

        public int getidmaestrohabilidad
        {
            get
            {
                return _idmaestro_habilidad;
            }
            set
            {
                _idmaestro_habilidad = value;
            }
        }

        public int getidmaestro
        {
            get
            {
                return _idmaestro;
            }
            set
            {
                _idmaestro = value;
            }
        }

        public int getidhabilidad
        {
            get
            {
                return _idhabilidad;
            }
            set
            {
                _idhabilidad = value;
            }
        }

    }
}
