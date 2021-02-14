using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using capaEntidad;
using System.Data;
using System.Windows.Forms;

namespace CapaConexion
{
    public class ClassDatosProveedor : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlParameter p;

        public bool insert_proveedor(ClassEntidadProveedor proveedor)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_proveedor_in",cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_razon_social", MySqlDbType.VarChar);
                p.Value = proveedor.getrazonsocial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nit", MySqlDbType.VarChar);
                p.Value = proveedor.getnit;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = proveedor.gettelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_correo", MySqlDbType.VarChar);
                p.Value = proveedor.getcorreo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = proveedor.getdireccion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idtipo_persona", MySqlDbType.Int64);
                p.Value = proveedor.getidtipopersona;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = proveedor.getidciudad;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }


        public bool update_proveedor(ClassEntidadProveedor proveedor)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_proveedor_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idproveedor", MySqlDbType.Int64);
                p.Value = proveedor.getidproveedor;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_razon_social", MySqlDbType.VarChar);
                p.Value = proveedor.getrazonsocial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nit", MySqlDbType.VarChar);
                p.Value = proveedor.getnit;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = proveedor.gettelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_correo", MySqlDbType.VarChar);
                p.Value = proveedor.getcorreo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = proveedor.getdireccion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idtipo_persona", MySqlDbType.Int64);
                p.Value = proveedor.getidtipopersona;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = proveedor.getidciudad;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool delete_proveedor(ClassEntidadProveedor proveedor)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_proveedor_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idproveedor", MySqlDbType.Int64);
                p.Value = proveedor.getidproveedor;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public DataTable Listar()
        {
            try
            {
                cnn = conectar();
                da = new MySqlDataAdapter("sp_listar_proveedor", cnn);
                dt = new DataTable();
                da.Fill(dt);
                return this.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return this.dt;
                throw;
            }
        }


    }
}
