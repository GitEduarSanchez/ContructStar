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
    public class ClassDatosTipoMaterial : CapaDatos.ClassConexion
    {
        DataTable dt;
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlParameter p;

        public bool insert_tipo_material(ClassEntidadTipoMaterial tipomaterial)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_material_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = tipomaterial.getDescripcion;
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

        public bool update_tipo_material(ClassEntidadTipoMaterial tipomaterial)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_material_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idtipo_material", MySqlDbType.Int64);
                p.Value = tipomaterial.getIdTipoMaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = tipomaterial.getDescripcion;
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

        public bool delete_tipo_material(ClassEntidadTipoMaterial tipomaterial)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_material_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idtipo_material", MySqlDbType.Int64);
                p.Value = tipomaterial.getIdTipoMaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

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
                da = new MySqlDataAdapter("sp_listar_tipo_material", cnn);
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