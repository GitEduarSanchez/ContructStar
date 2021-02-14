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
    public class ClassDatosMaestro : CapaDatos.ClassConexion
    {
        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_maestro(ClassEntidadMaestro maestro)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = maestro.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_apellido", MySqlDbType.VarChar);
                p.Value = maestro.getapellido;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_documento", MySqlDbType.VarChar);
                p.Value = maestro.getdocumento;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = maestro.getTelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_correo", MySqlDbType.VarChar);
                p.Value = maestro.getcorreo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = maestro.getdireccion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = maestro.getidciudad;
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

        public bool update_maestro(ClassEntidadMaestro maestro)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaestro", MySqlDbType.Int64);
                p.Value = maestro.getidmaestro;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = maestro.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_apellido", MySqlDbType.VarChar);
                p.Value = maestro.getapellido;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_documento", MySqlDbType.VarChar);
                p.Value = maestro.getdocumento;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = maestro.getTelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_correo", MySqlDbType.VarChar);
                p.Value = maestro.getcorreo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = maestro.getdireccion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = maestro.getidciudad;
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

        public bool delete_maestro(ClassEntidadMaestro maestro)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaestro", MySqlDbType.Int64);
                p.Value = maestro.getidmaestro;
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
                da = new MySqlDataAdapter("sp_listar_maestro", cnn);
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
