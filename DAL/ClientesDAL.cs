﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Reflection.PortableExecutable;
using System.Data;
using Microsoft.Identity.Client;

namespace DAL
{
    public class ClientesDAL
    {
        public void Incluir(ClienteInformation cliente)
        {    //cria objeto cn para receber a conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                //carrega a string da conexao do SQL Server
                cn.ConnectionString =
                //cria objeto cmd para executar comandos
                SqlCommand cmd = new SqlCommand();
                //cmd receba a string de conexao
                cmd.Connection = cn;
                //define que usaremos Stored Procadure do SQL Server
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //nome da Stored Procadure que sera usada
                cmd.CommandText = "insere_cliente";
                //parametros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.NVarChar, 100);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

            } 
            catch (Exception ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            public void Alterar(ClienteInformation cliente)
            {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw new Exception("Servidor Sql Erro: " + Message);

            }
            finally
            {
                cn.Close();
            }
            public DataTable                       
        }
    }
}
