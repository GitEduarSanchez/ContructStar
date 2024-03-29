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
    public class ClassDatosPais : CapaDatos.ClassConexion
    {


        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_pais(ClassEntidadPais pais)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_pais_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = pais.getdescripcion;
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

        public bool update_pais(ClassEntidadPais pais)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_pais_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpais", MySqlDbType.Int64);
                p.Value = pais.getidpais;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_descripcion", MySqlDbType.VarChar);
                p.Value = pais.getdescripcion;
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

        public bool delete_pais(ClassEntidadPais pais)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_pais_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idpais", MySqlDbType.Int64);
                p.Value = pais.getidpais;
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
                da = new MySqlDataAdapter("sp_listar_pais", cnn);
                dt = new DataTable();
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
