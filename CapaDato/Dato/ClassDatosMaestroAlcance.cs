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
    public class ClassDatosMaestroAlcance : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_maestro_alcance(ClassEntidadMaestroAlcance alcance)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_alcance_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaestro", MySqlDbType.Int64);
                p.Value = alcance.getidmaestro;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = alcance.getidciudad;
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

        public bool update_maestro_alcance(ClassEntidadMaestroAlcance alcance)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_alcance_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaestro_alcance", MySqlDbType.Int64);
                p.Value = alcance.getidmaestroalcance;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idmaestro", MySqlDbType.Int64);
                p.Value = alcance.getidmaestro;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = alcance.getidciudad;
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

        public bool delete_maestro_alcance(ClassEntidadMaestroAlcance alcance)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_maestro_alcance_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaestro", MySqlDbType.Int64);
                p.Value = alcance.getidmaestro;
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
                da = new MySqlDataAdapter("sp_listar_maestro_alcance", cnn);
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
