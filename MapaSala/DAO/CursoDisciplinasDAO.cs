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
            string query = "insert into Curso_Disciplina (Curso_Id, Disciplina_Id, Periodo) Values (@cursoid, @disciplinaid, @periodo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@cursoid", curso.CursoId);
            SqlParameter parametro2 = new SqlParameter("@disciplinaid", curso.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@periodo", curso.Periodo);

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
            string query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo Periodo FROM CURSO_DISCIPLINA CD
                            INNER JOIN CURSOS C ON (C.Id = CD.Curso_Id)
                            INNER JOIN DISCIPLINAS D ON (D.Id = CD.Disciplina_Id)
                            ORDER BY CD.Id DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            dt.Columns.Add("NomeCurso");
            dt.Columns.Add("NomeDisciplina");
            dt.Columns.Add("Periodo");

            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    CursoDisciplinaEntidade curso = new CursoDisciplinaEntidade();
                    curso.NomeCurso = Leitura[0].ToString();
                    curso. NomeDisciplina = Leitura[1].ToString();
                    curso.Periodo = Leitura[2].ToString();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}

