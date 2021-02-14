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
    public class ClassDatosMaterial : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_(ClassEntidadMaterial material)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_material_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = material.getdescripcion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_especificaciones", MySqlDbType.VarChar);
                p.Value = material.getespecificaciones;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idmarca", MySqlDbType.Int64);
                p.Value = material.getidmarca;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idtipo_material", MySqlDbType.Int64);
                p.Value = material.getidtipomaterial;
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

        public bool update_material(ClassEntidadMaterial material)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_material_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaterial", MySqlDbType.Int64);
                p.Value = material.getidmaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = material.getdescripcion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_especificaciones", MySqlDbType.VarChar);
                p.Value = material.getespecificaciones;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idmarca", MySqlDbType.Int64);
                p.Value = material.getidmarca;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idtipo_material", MySqlDbType.Int64);
                p.Value = material.getidtipomaterial;
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

        public bool delete_material(ClassEntidadMaterial material)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_material_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaterial", MySqlDbType.Int64);
                p.Value = material.getidmaterial;
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
                da = new MySqlDataAdapter("sp_listar_material", cnn);
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
