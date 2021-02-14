using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ClassEntidadMaterialPorProveedor
    {

        private int _idmaterial_por_proveedor;
        private int _idproveedor;
        private int _idpresentacion_por_material;
        private double _precio;

        public int getidmaterialporproveedor
        {
            get { return _idmaterial_por_proveedor; }
            set { _idmaterial_por_proveedor = value; }
        }

        public int getidproveedor
        {
            get { return _idproveedor; }
            set { _idproveedor = value; }
        }

        public int getidpresentacionpormaterial
        {
            get { return _idpresentacion_por_material; }
            set { _idpresentacion_por_material = value; }
        }
        
        public double getprecio
        {
            get { return _precio; }
            set { _precio = value; }
        }
    }
}
