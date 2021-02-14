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



    public class ClassDatosTipoPersona : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlParameter p;

        public bool  insert_tipo_persona(ClassEntidadTipoPersona Tipopersona)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_persona_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", cnn);
                p.Value = Tipopersona.getDescripcion;
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

        public bool update_tipo_persona(ClassEntidadTipoPersona Tipopersona)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_persona_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpersona", MySqlDbType.Int64);
                p.Value = Tipopersona.getIdPersona;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", cnn);
                p.Value = Tipopersona.getDescripcion;
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

        public bool delete_tipo_persona(ClassEntidadTipoPersona Tipopersona)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_tipo_persona_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpersona", MySqlDbType.Int64);
                p.Value = Tipopersona.getIdPersona;
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
                da = new MySqlDataAdapter("sp_listar_tipo_persona", cnn);
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
