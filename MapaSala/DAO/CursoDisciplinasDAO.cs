using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entitidades;


namespace MapaSala.DAO
{
    public class CursoDisplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public CursoDisplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(CursoDisciplinaEntidade curso)
        {
            Conexao.Open();
            string query = "insert into CursoDisciplinas (CursoId, DisciplinaId, Periodo) Values (@cursoid, @disciplinaid, @periodo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@cursoid", curso.CursoId);
            SqlParameter parametro2 = new SqlParameter("@disciplinaid", curso.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@perido", curso.Periodo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable ObterCursoDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM CURSO ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(CursoDisciplinaEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    CursoDisciplinaEntidade curso = new CursoDisciplinaEntidade();
                    curso.Id = Convert.ToInt32(Leitura[0]);
                    curso.CursoId = Convert.ToInt32(Leitura[1]);
                    curso.DisciplinaId = Convert.ToInt32(Leitura[2]);
                    curso. NomeDisciplina = Leitura[3].ToString();
                    curso.NomeCurso = Leitura[4].ToString();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}

