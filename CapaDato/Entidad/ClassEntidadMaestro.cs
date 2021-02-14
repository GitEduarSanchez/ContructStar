using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
   public class ClassEntidadMaestro
    {


        private int _idmaestro;
        private string _nombre;
        private string _apellido;
        private string _documento;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private int _idciudad;

        public int getidmaestro
        {
            get { return _idmaestro; }
            set { _idmaestro = value; }
        }

        public string getnombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string getapellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string getdocumento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        public string getTelefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string getcorreo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public string getdireccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int getidciudad
        {
            get { return _idciudad; }
            set { _idciudad = value; }
        }

    }

}
