using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadPresentacionPorMaterial
    {
        private int _idpresentacion_por_material;
        private int _idmaterial;
        private int _idpresentacion;
        private string _medidas;
        private string _espesor;
        private int _idund;

        public int getidpresentacionpormaterial
        {
            get
            {
                return _idpresentacion_por_material;
            }
            set
            {
                _idpresentacion_por_material = value;
            }
        }

        public int getidmaterial
        {
            get
            {
                return _idmaterial;
            }
            set
            {
                _idmaterial = value;
            }
        }

        public int getidpresentacion
        {
            get { return _idpresentacion; }
            set { _idpresentacion = value; }
        }

        public string getmedida
        {
            get { return _medidas; }
            set { _medidas = value; }
        }

        public string getespesor
        {
            get { return _espesor; }
            set { _espesor = value; }
        }

        public int getidund
        {
            get { return _idund; }
            set { _idund = value; }
        }

    }
}
