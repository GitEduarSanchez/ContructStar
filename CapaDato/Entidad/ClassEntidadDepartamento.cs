using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadDepartamento
    {
        private int _iddepartamento;
        private string _departamento;
        private int _idpais;

        public int getiddepartamento
        {
            get { return _iddepartamento; }
            set { _iddepartamento = value; }
        }

        public string getdepartamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        public int getidpais
        {
            get { return _idpais; }
            set { _idpais = value; }
        }

    }
}
