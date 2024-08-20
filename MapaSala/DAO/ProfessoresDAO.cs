using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entitidades;
using System.Data;

namespace MapaSala.DAO
{
    public class ProfessoresDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public ProfessoresDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "insert into Professores(Nome, Apelido) Values (@nome, @apelido)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable ObterProfessores()
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
                    ProfessoresEntidade prof = new ProfessoresEntidade();
                    prof.Id = Convert.ToInt32(Leitura[0]);
                    prof.Nome = Leitura[1].ToString();
                    prof.Apelido = Leitura[2].ToString();
                    dt.Rows.Add(prof.Linha());
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
             query = "SELECT * FROM PROFESSORES WHERE NOME LIKE '%"+pesquisa+"%' ORDER BY ID desc"; //concatenação
            }
            
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
                    ProfessoresEntidade prof = new ProfessoresEntidade();
                    prof.Id = Convert.ToInt32(Leitura[0]);
                    prof.Nome = Leitura[1].ToString();
                    prof.Apelido = Leitura[2].ToString();
                    dt.Rows.Add(prof.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}