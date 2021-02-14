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
    public class ClassDatosUnd : CapaDatos.ClassConexion
    {


        DataTable dt;
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlParameter p;

        public bool insert_und(ClassEntidadUnd und)
        {
            try
            {
                cnn = conectar();
                cmd =new MySqlCommand("sp_insert_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = und.getDescripcion;
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

        public bool update_und(ClassEntidadUnd und)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_und_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idund", MySqlDbType.Int64);
                p.Value = und.getIdund;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = und.getDescripcion;
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

        public bool delete_und(ClassEntidadUnd und)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_und_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idund", MySqlDbType.Int64);
                p.Value = und.getIdund;
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
                da = new MySqlDataAdapter("sp_listar_und", cnn);
                dt = new DataTable();
                da.Fill(dt);
                return this.dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return this.dt;
            }
        }
    }
}

