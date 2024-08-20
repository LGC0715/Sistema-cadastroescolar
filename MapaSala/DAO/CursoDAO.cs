using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MapaSala.DAO
{
    public class CursoDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public CursoDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(cursoEntidades curso)
        {
            Conexao.Open();
            string query = "insert into Curso(Id, Nome, Turno, Ativo) Values (@id, @nome, @turno, @ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@id", curso.Id);
            SqlParameter parametro2 = new SqlParameter("@nome", curso.Nome);
            SqlParameter parametro3 = new SqlParameter("@turno", curso.Turno);
            SqlParameter parametro4 = new SqlParameter("@ativo", curso.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4); 
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable ObterCurso()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM CURSO ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(cursoEntidades).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    cursoEntidades curso = new cursoEntidades();
                    curso.Id = Convert.ToInt32(Leitura[0]);
                    curso.Nome = Leitura[1].ToString();
                    curso.Turno = Leitura[2].ToString();
                    //curso.Ativo = Leitura[3].checked();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
