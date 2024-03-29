﻿using System;
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
    public class ClassDatosHabilidad : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_habilidad(ClassEntidadHabilidad habilidad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_habilidad_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = habilidad.getdescripcion;
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

        public bool update_habilidad(ClassEntidadHabilidad habilidad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_habilidad_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idhabilidad", MySqlDbType.Int64);
                p.Value =habilidad.getidhabilidad ;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = habilidad.getdescripcion;
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

        public bool delete_habilidad(ClassEntidadHabilidad habilidad)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_habilidad_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idhabilidad", MySqlDbType.Int64);
                p.Value = habilidad.getidhabilidad;
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
                da = new MySqlDataAdapter("sp_listar_habilidad", cnn);
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
