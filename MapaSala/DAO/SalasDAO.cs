using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    public class SalasDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public SalasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(SalasEntidade sala)
        {
            Conexao.Open();
            string query = "insert into Salas(Nome, NumeroComputadores, NumeroCadeiras, IsLab, Disponivel) Values (@nome, @numerocomputadores, @numerocadeiras, @islab, @disponivel)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", sala.Nome);
            SqlParameter parametro2 = new SqlParameter("@numerocomputadores", sala.NumeroComputadores);
            SqlParameter parametro3 = new SqlParameter("@numerocadeiras", sala.NumeroCadeiras);
            SqlParameter parametro4 = new SqlParameter("@islab", sala.IsLab);
            SqlParameter parametro5 = new SqlParameter("@disponivel", sala.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable ObterSalas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM PROFESSORES ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    SalasEntidade sala = new SalasEntidade();
                    sala.Id = Convert.ToInt32(Leitura[0]);
                    sala.Nome = Leitura[1].ToString();
                    sala.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    sala.NumeroComputadores = Convert.ToInt32(Leitura[3]);
                    sala.Disponivel = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(sala.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT * FROM PROFESSORES ORDER BY ID desc";
            }
            else
            {
                query = "SELECT * FROM PROFESSORES WHERE NOME LIKE '%" + pesquisa + "%' ORDER BY ID desc"; //concatenação
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    SalasEntidade sala = new SalasEntidade();
                    sala.Id = Convert.ToInt32(Leitura[0]);
                    sala.Nome = Leitura[1].ToString();
                    sala.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    sala.NumeroComputadores = Convert.ToInt32(Leitura[3]);
                    sala.Disponivel = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(sala.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
