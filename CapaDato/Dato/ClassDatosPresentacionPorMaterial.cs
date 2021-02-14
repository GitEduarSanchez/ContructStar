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
    public class ClassDatosPresentacionPorMaterial : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_presentacion_por_material(ClassEntidadPresentacionPorMaterial presentacion)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_presentacion_por_material_in",cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idmaterial",MySqlDbType.Int64);
                p.Value = presentacion.getidmaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idpresentacion", MySqlDbType.Int64);
                p.Value = presentacion.getidpresentacion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_medidas", MySqlDbType.VarChar);
                p.Value = presentacion.getmedida;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_espesor", MySqlDbType.VarChar);
                p.Value = presentacion.getespesor;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idund", MySqlDbType.Int64);
                p.Value = presentacion.getidund;
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

        public bool update_presentacion_por_material(ClassEntidadPresentacionPorMaterial presentacion)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_presentacion_por_material_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpresentacion_por_material", MySqlDbType.Int64);
                p.Value = presentacion.getidmaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idmaterial", MySqlDbType.Int64);
                p.Value = presentacion.getidmaterial;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idpresentacion", MySqlDbType.Int64);
                p.Value = presentacion.getidpresentacion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_medidas", MySqlDbType.VarChar);
                p.Value = presentacion.getmedida;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);


                p = new MySqlParameter("?_espesor", MySqlDbType.VarChar);
                p.Value = presentacion.getespesor;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);


                p = new MySqlParameter("?_idund", MySqlDbType.Int64);
                p.Value = presentacion.getidund;
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

        public bool delete_presentacion_por_material(ClassEntidadPresentacionPorMaterial presentacion)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_presentacion_por_material_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpresentacion_por_material", MySqlDbType.Int64);
                p.Value = presentacion.getidmaterial;
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
                da = new MySqlDataAdapter("sp_lista_presentacion_por_materia", cnn);
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
