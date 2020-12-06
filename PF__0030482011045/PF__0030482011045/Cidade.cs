﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PF__0030482011045
{
    class Cidade
    {
        private int IDCidade;
        private string nomeCidade;
        private string Ufcidade;


        public int idcidade
        {
            get
            {
                return IDCidade;
            }
            set
            {
                IDCidade = value;
            }
        }

        public string Nomecidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }

        public string ufCidade
        {
            get
            {
                return Ufcidade;
            }
            set
            {
                Ufcidade = value;
            }

            
        }
         public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM TBCIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO TBCIDADE VALUES (@nome_cidade, @uf_cidade)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }

            }
            catch (Exception ex)

            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBCIDADE SET nome_cidade = @nome_cidade ,uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@id_cidade"].Value = IDCidade;
                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)

                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM TBCIDADE WHERE id_cidade = @id_cidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value = IDCidade;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }






    }
}
