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
    class ClassDatosCiudad : CapaDatos.ClassConexion
    {


        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_ciudad(ClassEntidadCiudad ciudad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_ciudad_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = ciudad.getidciudad;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddepartamento", MySqlDbType.Int64);
                p.Value = ciudad.getiddepartamento;
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

        public bool update_ciudad(ClassEntidadCiudad ciudad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_ciudad_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = ciudad.getidciudad;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = ciudad.getidciudad;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddepartamento", MySqlDbType.Int64);
                p.Value = ciudad.getiddepartamento;
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

        public bool delete_ciudad(ClassEntidadCiudad ciudad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_ciudad_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;


                p = new MySqlParameter("?_idciudad", MySqlDbType.Int64);
                p.Value = ciudad.getidciudad;
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
                da = new MySqlDataAdapter("sp_listar_ciudad", cnn);
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
