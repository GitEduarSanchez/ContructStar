using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadManoObra
    {
        private int _idmano_obra;
        private int _idmaestro;
        private int _idactividad;
        private int _idund;
        private double _precio;


        public int getidmanoobra
        {
            get { return _idmano_obra; }
            set { _idmano_obra = value; }
        }

        public int getidmaestro
        {
            get { return _idmaestro; }
            set
            {
                _idmaestro=value;
            }
        }
        
        public int getidactividad
        {
            get { return _idactividad; }
            set
            {
                _idactividad = value;
            }
        }

        public int getidund
        {
            get { return _idund; }
            set { _idund = value; }
        }

        public double getprecio
        {
            get { return _precio; }
            set { _precio = value; }
        }

    }
}
