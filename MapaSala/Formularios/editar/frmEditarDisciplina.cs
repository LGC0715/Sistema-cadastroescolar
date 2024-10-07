using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.editar
{
    public partial class frmEditarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao;
        public partial class frmEditarDisciplina(int DisciplinaId)
        {
            InitializeComponent();
            string query = "select Id, Nome, Sigla, Ativo from Disciplinas where Id= @id";

        DataTable dt = new DataTable();
        Conexao.Open();
        SqlCommand Comando = new SqlCommand(query, Conexao);
        comando.Parameters.Add(new SqlParameter ("@id", DisciplinaId))

        SqlDataReader Leitura = Comando.ExecuteReader();
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
        
                    label_id.Text = Leitura[0].ToString();
                    txtNomeDisciplina.Text = Leitura[1].ToString();
                    chk_nome.Checked = Convert.ToBoolean(Leitura[3])
                    
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}