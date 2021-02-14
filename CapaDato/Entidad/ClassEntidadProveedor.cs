using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadProveedor
    {
        private int _idproveedor;
        private string _razon_social;
        private string _nit;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private int _idtipo_persona;
        private int _idciudad;

        public int getidproveedor
        {
            get
            {
                return _idproveedor;
            }
            set
            {
                _idproveedor = value;
            }
        }

        public string getrazonsocial
        {
            get
            {
                return _razon_social;
            }
            set
            {
                _razon_social = value;
            }
        }

        public string getnit
        {
            get
            {
                return _nit;
            }
            set
            {
                _nit = value;
            }
        }

        public string gettelefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string getcorreo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }

        public string getdireccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public int getidtipopersona
        {
            get
            {
                return _idtipo_persona;
            }
            set
            {
                _idtipo_persona = value;
            }
        }

        public int getidciudad
        {
            get
            {
                return _idciudad;
            }
            set
            {
                _idciudad = value;
            }
        }
    }
}
